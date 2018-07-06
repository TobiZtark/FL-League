using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneloadString : MonoBehaviour {

    public string Scenename;
   
    // Use this for initialization

    public void AnyScene()
    {
        SceneManager.LoadScene(Scenename);
        PlayerPrefs.DeleteKey("timer");
    }

}
