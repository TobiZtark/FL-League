using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IndexMgr : MonoBehaviour {
    public GameObject loadScreen;

public void OnClick (){

        StartCoroutine(LoadHome());
        
    }

	public void OnClick1 (){
		SceneManager.LoadScene("Play");

	}

    public void OnClick2()
    {
        SceneManager.LoadScene("PlayLA");

    }

    public void OnClick3()
    {
        SceneManager.LoadScene("PlayBU");

    }

    public void OnClick4()
    {
        SceneManager.LoadScene("PlaySA");

    }

    public void OnClick5()
    {
        SceneManager.LoadScene("PlayS");

    }
    public void NewGame()
	{
		PlayerPrefs.DeleteAll ();
	}

    IEnumerator LoadHome()
    {
        loadScreen.SetActive(true);
        
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Home");       
     //  loadScreen.SetActive(false);

    }
}

