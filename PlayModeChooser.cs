using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayModeChooser : MonoBehaviour {
    public GameObject dialog;
    public GameObject button1;
    public GameObject button2;
    public Text messageText;
    public string Scenename;
    public string access = "Logs Open";
    public string injury = "Injury Time, Hurry!";
    // Use this for initialization
    private void Start()
    {
        
        button2.SetActive(false);
        dialog.SetActive(false);
        button2.SetActive(false);
    }
    public void RandomLog()
    {

        if (PlayerPrefs.GetString("Timer") == access || PlayerPrefs.GetString("Timer") == injury)
        {
            
            messageText.text = "";
            if (PlayerPrefs.GetInt("LOGGED_IN") == 1)
            {
                SceneManager.LoadScene(Scenename);
            }
            else
            {
                dialog.SetActive(true);
                button2.SetActive(true);
                messageText.text = "Kindly Register or Login to Continue";
            }
        }
        else
        {
            
            dialog.SetActive(true);
            button2.SetActive(true);
            messageText.text = "Logs are currently closed. This is due to Internet Connectivity or Matchday Deadline. Please Reload the Tab or try again later.";
        }
        }

    public void Bacck()
    {
        dialog.SetActive(false);
    }
}
