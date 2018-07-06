using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	public GameObject LoggedUI;
	public Text loggedText;
	public Text bank;
	public Text score;

	void Start () {
		if (PlayerPrefs.GetInt ("LOGGED_IN") == 1) {
			//Debug.Log ("working.. logged in");
			LoggedUI.SetActive(true);
			loggedText.text = "Welcome "+ PlayerPrefs.GetString ("username");
			bank.text = "MyBank: $" + PlayerPrefs.GetInt ("DBank");
			score.text = "LLPoints: " + PlayerPrefs.GetInt ("DScore");

		} else
            LoggedUI.SetActive(false);
        //Debug.Log ("Not equal to 1");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
