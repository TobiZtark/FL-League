using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnySceneLoader : MonoBehaviour
{
    
    public string Scenename;
    public string Scenename1;
    // Use this for initialization

    public void AnyScene()
    {
            SceneManager.LoadScene(Scenename);
        }


    public void Bakk()
    {
        SceneManager.LoadScene(Scenename1);
    }
}
