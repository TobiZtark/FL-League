using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logout : MonoBehaviour {

    public GameObject loadingScreen;
    public GameObject quitScreen;

    public void Loggout()
    {
        PlayerPrefs.DeleteAll();
        quitScreen.SetActive(false);
        StartCoroutine(LoadIndex());
    }


    IEnumerator LoadIndex()
    {
        loadingScreen.SetActive(true);

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Index");
       // loadingScreen.SetActive(false);

    }
}
