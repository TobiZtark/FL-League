using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForgotPass : MonoBehaviour {


	public InputField GameIDText;
	public Text messageText; 
	public Text messageText1;
	public GameObject LoadingScreen;
	public GameObject quitScreen;
	private string fword;
	public string A = "Awaiting response...";


	public void FPass()
	{
		messageText.text = ""; //CLEAR ANY DISPLAYED MESSAGES TO THE PLAYER

		fword = GameIDText.text;    //POPULATE THE PRIVATE username VARIABLE WITH THE TEXT THE PLAYER ENTERED INTO THE usernameText INPUT FIELD


		if (fword == "") //IF THE PLAYER HASN'T ENTERED THE REQUIRED INFORMATION...TELL THEM TO
			messageText.text = "Please fill the field with GameID, phone number or Email";
		else    //IF ALL INFORMATION IS ENTERED, BUILD A WWWForm AND SEND IT TO THE SERVER
		{

			messageText.text = "Awaiting response...";
			if (messageText.text == A) {
				LoadingScreen.SetActive (true);
			}
			WWWForm form = new WWWForm();
			form.AddField("username", fword);
			WWW w = new WWW("http://loglords.uphero.com/fpass.php", form);    
			StartCoroutine(FPass(w));
		}
	}

	//WE USE COROUTINES TO SEND INFORMATION TO THE SERVER, SO THAT WE CAN WAIT FOR A RESPONSE
	IEnumerator FPass(WWW w)
	{
		yield return w;    //WAIT FOR A RESPONSE FROM THE SERVER

		if (w.error == null) { 

			LoadingScreen.SetActive (false);
			quitScreen.SetActive (true);

			if (w.text == "Email Sent")
			{   
				
				messageText1.text = fword + " was found on Log Lords Server and your lost password has been sent to your Email";

			} else 
			{


				messageText1.text = w.text;
			}//THE PHP SCRIPT SUPPLIED WILL TELL THE PLAYER IF THEIR PASSWORD IS INCORRECT, OR IF THEIR USERNAME DOESN'T EXIST
		} else 
		{

			LoadingScreen.SetActive (false);
			messageText.text = "ERROR: " + w.error;

		}//IF THERE IS AN ERROR (SUCH AS THE SERVER BEING DOWN) THE PHP SCRIPT SUPPLIED WILL TELL THE PLAYER

	}
		public void Back()
		{
			quitScreen.SetActive (false);
		}
	}