using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditFixtures : MonoBehaviour {

    public GameObject submit;
    public GameObject dragpanel;

 public void Edit()
    {
        submit.SetActive(false);
        dragpanel.SetActive(true);
    }
}
