using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSubmission : MonoBehaviour {

    public GameObject panel1;
    public GameObject panel2;
    public GameObject loadScreen;

    private void Start()
    {
        panel2.SetActive(false);
            
    }

    public void Loader()
    {
        loadScreen.SetActive(true);
        StartCoroutine(Hollup());
    }
    
	IEnumerator Hollup() {

        yield return new WaitForSeconds(5);
        panel1.SetActive(false);
        loadScreen.SetActive(false);
        panel2.SetActive(true);
    }
}
