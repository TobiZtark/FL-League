using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoginScript : MonoBehaviour
{
	//THE FOLLOWING ARE REFERENCES TO THE UI INPUT FIELDS THAT THE PLAYER TYPES INTO
	int RegBonus = 100;
	int Scoreline = 0;
	int MyBank;
	public InputField GameIDText, PasswordText, regUsernameText, regPassText, regConfPassText, regEmailText;
	public Text messageText; 
	public Text messageText1;
    public Text timer;
    public Text bank;
	public Text score;//THIS IS THE TEXT TO BE DISPLAYED ON SCREEN TO THE PLAYER
	public GameObject RegUI;
	public GameObject LoggedUI;
	public GameObject DropDown;
	public GameObject LogPan;
	public GameObject RegPan;
	public GameObject LoadingScreen;
    public GameObject quitScreen;

    public string A = "Awaiting response...";
	//THE FOLLOWING VARIBALES ARE POPULATED BY THE TEXT THE PLAYER ENTERS INTO THE CORRESPONDING INPUT FIELDS
	private string username, password, regName, regUsername, regPass, regConfPass, regEmail;



	public void Start()
	{//FUNCTION TO BE CALLED VIA THE UI BUTTON
        if (PlayerPrefs.GetInt ("LOGGED_IN") == 1) {
			//Debug.Log ("working.. logged in");
			LoggedUI.SetActive (true);
			messageText1.text = "Welcome " + PlayerPrefs.GetString ("username");
			bank.text = "MyBank: $" + PlayerPrefs.GetInt ("DBank");
			score.text = "LLPoints: " + PlayerPrefs.GetInt ("DScore");

		} else
			LoggedUI.SetActive (false);
	}

   /* public void Update()
    {
        WWWForm form = new WWWForm();
        form.AddField("timer", timer.text);
        WWW w = new WWW("http://loglords.uphero.com/gtime.php", form);
        StartCoroutine(Timer(w));
    }*/
    
	public void LogIn()
	{
		messageText.text = ""; //CLEAR ANY DISPLAYED MESSAGES TO THE PLAYER

		username = GameIDText.text;    //POPULATE THE PRIVATE username VARIABLE WITH THE TEXT THE PLAYER ENTERED INTO THE usernameText INPUT FIELD
		password = PasswordText.text;    //POPULATE THE PRIVATE password VARIABLE WITH THE TEXT THE PLAYER ENTERED INTO THE passwordText INPUT FIELD

		if (username == "" || password == "") //IF THE PLAYER HASN'T ENTERED THE REQUIRED INFORMATION...TELL THEM TO
			messageText.text = "Please fill all fields.";
		else    //IF ALL INFORMATION IS ENTERED, BUILD A WWWForm AND SEND IT TO THE SERVER
		{
			
			messageText.text = "Awaiting response...";
			if (messageText.text == A) {
				LoadingScreen.SetActive (true);
			}
            WWWForm form = new WWWForm();
            form.AddField("username", username);
			form.AddField("password", password);
			WWW w = new WWW("http://loglords.uphero.com/login.php", form);    
			StartCoroutine(LogIn(w));
            //Debug.Log(username);
        }
	}
    //FUNCTION TO BE CALLED VIA THE UI BUTTON
    public void Register()
    {
        messageText.text = ""; //CLEAR ANY DISPLAYED MESSAGES TO THE PLAYER


        regUsername = regUsernameText.text;    //POPULATE THE PRIVATE regUsername VARIABLE WITH THE TEXT THE PLAYER ENTERED INTO THE regUsernameText INPUT FIELD
        regPass = regPassText.text;    //POPULATE THE PRIVATE USERNAME regPass WITH THE TEXT THE PLAYER ENTERED INTO THE pregPassText INPUT FIELD
        regConfPass = regConfPassText.text;    //POPULATE THE PRIVATE regConfPass VARIABLE WITH THE TEXT THE PLAYER ENTERED INTO THE regConfPassText INPUT FIELD
        regEmail = regEmailText.text;    //POPULATE THE PRIVATE regEmail VARIABLE WITH THE TEXT THE PLAYER ENTERED INTO THE regEmailText INPUT FIELD

        if (regUsername == "" || regPass == "" || regConfPass == "" || regEmail == "")
        {//IF THE PLAYER HASN'T ENTERED THE REQUIRED INFORMATION...TELL THEM TO
            messageText.text = "Please fill all fields correctly.";
        }
        else
        {
            if (regPass != regConfPass)    //......AND THE PASSWORDS MATCH, BUILD A WWWForm AND SEND IT TO THE SERVER
            {
                messageText.text = "Your passwords do not match. Please try again.";
            }
            else   //......AND THE PASSWORDS DON'T MATCH, TELL THE PLAYER
            {
                messageText.text = "Awaiting response...";
                if (messageText.text == A)
                {
                    LoadingScreen.SetActive(true);
                }
                WWWForm form = new WWWForm();
                form.AddField("username", regUsername);
                form.AddField("password", regPass);
                form.AddField("email", regEmail);
                // form.AddField("bank", MyBank);
                //  form.AddField("scores", score);
                WWW w = new WWW("http://loglords.uphero.com/insert.php", form);
                StartCoroutine(Register(w));

            }
        }
    }

	//WE USE COROUTINES TO SEND INFORMATION TO THE SERVER, SO THAT WE CAN WAIT FOR A RESPONSE
	 IEnumerator LogIn(WWW w)
	{
		yield return w;    //WAIT FOR A RESPONSE FROM THE SERVER

		if (w.error == null) { 
							
			LoadingScreen.SetActive (false);
			PlayerPrefs.SetString ("username", username);
			//Logged ();
			bank.text = "MyBank: $" + PlayerPrefs.GetInt ("MyBank");
			score.text = "LLPoints: "+ PlayerPrefs.GetInt ("Scoreline");
			messageText1.text = "Welcome " + username; //IF THE SERVER DOESN'T SEND BACK AN ERROR
                                                       // Debug.Log(w.text);           
            if (w.text == "Log in successful!")
			{    //THE PHP SCRIPT SUPPLIED WILL SEND THIS MESSAGE BACK IF THE LOGIN WAS SUCCESSFUL
               // print("Logged In");
                Logged();
                
			} else 
			{
				
				LoadingScreen.SetActive (false);
				messageText.text = w.text;
			}//THE PHP SCRIPT SUPPLIED WILL TELL THE PLAYER IF THEIR PASSWORD IS INCORRECT, OR IF THEIR USERNAME DOESN'T EXIST
		} else 
		{
			
			LoadingScreen.SetActive (false);
			messageText.text = "ERROR: " + w.error;

		}//IF THERE IS AN ERROR (SUCH AS THE SERVER BEING DOWN) THE PHP SCRIPT SUPPLIED WILL TELL THE PLAYER
	}
	 IEnumerator Register(WWW w)
	{
		yield return w;    //WAIT FOR A RESPONSE FROM THE SERVER

		if (w.error == null) 
		{ //IF THE SERVER DOESN"T SEND BACK AN ERROR
			messageText.text = w.text; 
			MyBank = RegBonus;
			bank.text = "MyBank: $" + MyBank;
			score.text = "LLPoints: " + Scoreline;
			PlayerPrefs.SetInt("DBank", MyBank);
			PlayerPrefs.SetInt("DScore", Scoreline);
			LoadingScreen.SetActive (false);
			Logged ();
			messageText1.text = "Welcome " + regUsername;
			PlayerPrefs.SetString ("username", regUsername);
			RegUI.SetActive (false);
		}//THE PHP SCRIPT SUPPLIED WILL SEND A MESSAGE BACK TO THE PLAYER SAYING REGISTRATION WAS COMPLETED
		else 
		{
			
			LoadingScreen.SetActive (false);
			messageText.text = "ERROR: " + w.error; 

		}//IF THERE IS AN ERROR (SUCH AS THE SERVER BEING DOWN) THE PHP SCRIPT SUPPLIED WILL TELL THE PLAYER
	}


    public void Logging()
	{
			DropDown.SetActive (true);
			RegUI.SetActive (false);
			LoggedUI.SetActive (false);
			RegPan.SetActive (true);
		}


	public void Reg ()
	{
		DropDown.SetActive (false);
		RegUI.SetActive (true);
		LoggedUI.SetActive (false);
		//LogPan.SetActive (true);
	}

	public void Logged ()
	{
		
			LoggedUI.SetActive (true);
			RegPan.SetActive (false);
			LogPan.SetActive (false);
		    PlayerPrefs.SetInt ("LOGGED_IN", 1);

	}

	public void Back ()
	{
		RegUI.SetActive (false);
		RegPan.SetActive (true);
		LogPan.SetActive (true);
	}

/*	public void BackPlay ()
	{
		Application.LoadLevel("Play");
		RegUI.SetActive (false);
		LoggedUI.SetActive (true);
	}
	public void BackPlayII ()
	{
		Application.LoadLevel("");
		RegUI.SetActive (false);
		LoggedUI.SetActive (true);
	}*/
	public void Baccck()
	{
		LoadingScreen.SetActive (false);
	}

	public void QuitApp()
	{
		


	/*	//PlayerPrefs.DeleteAll ();
		#if UNITY_EDITOR
		// Application.Quit() does not work in the editor so
		// UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
		UnityEditor.EditorApplication.isPlaying = false;
        #else
		Application.Quit();
		//Debug.Log ("Working");
        #endif 
        */
        quitScreen.SetActive(true);
       
    }

    public void CancelQuit()
    {
        quitScreen.SetActive(false);
    }

   
}

