using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexBehaviour : MonoBehaviour {
    public GameObject newG;
    public GameObject startG;
    // Use this for initialization
    public void Start()
    {//FUNCTION TO BE CALLED VIA THE UI BUTTON
        if (PlayerPrefs.GetInt("LOGGED_IN") == 1)
        {
            //Debug.Log ("working.. logged in");
            startG.SetActive(true);
            newG.SetActive(true);
        }
        else
            startG.SetActive(false);
    }
}
