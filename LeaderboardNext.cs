using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeaderboardNext : MonoBehaviour {

    public GameObject list1;
    public GameObject list2;
    public GameObject next;
    public GameObject back;
    public GameObject back2;
    // Use this for initialization

    public void GotoNext()
    {
            list1.SetActive(false);
            list2.SetActive(true);
            next.SetActive(false);
            back.SetActive(false);
            back2.SetActive(true);
    }

    public void GoBack()
    {
        list1.SetActive(true);
        list2.SetActive(false);
        next.SetActive(true);
        back.SetActive(true);
        back2.SetActive(false);
    }

    public void QuitBoard()
    { 
            SceneManager.LoadScene("HomeLead");
    }

}
