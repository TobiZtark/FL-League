using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timer;

	// Use this for initialization
	void Start () {
		WWWForm form = new WWWForm ();
		form.AddField ("timer", timer.text);
		WWW w = new WWW ("http://loglords.uphero.com/gtime.php", form);
		StartCoroutine (Time (w));
	}

	IEnumerator Time(WWW w)
	{
		yield return w;    //WAIT FOR A RESPONSE FROM THE SERVER

		if (w.error == null)
		{ //IF THE SERVER DOESN"T SEND BACK AN ERROR
			timer.text = "Access Mode: " + w.text;
			PlayerPrefs.SetString("Timer", w.text);
		}
		else //IF THERE IS AN ERROR (SUCH AS THE SERVER BEING DOWN) THE PHP SCRIPT SUPPLIED WILL TELL THE PLAYER
		{
			timer.text = "ERROR: " + w.error;

		}
	}

}
