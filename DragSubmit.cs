using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DragSubmit : MonoBehaviour {

    public GameObject loadingScreen;
    public GameObject submitScreen;
    public GameObject cancelButton;
    public GameObject OkButton;
    public GameObject playback;
    public Text messageText;
    public Transform[] position;
    string username;
    //  List<Transform> team = new List<Transform>();
    string temp;
    // Use this for initialization
    public void Awake()
    {
        username = PlayerPrefs.GetString("username");
    }
    public void ClickSubmit()
    {
        submitScreen.SetActive(true);
    }

    public void ClickBack()
    {
        submitScreen.SetActive(false);
    }

    // Update is called once per frame
    void Submit ()
    {
        temp = "";
        loadingScreen.SetActive(true);
        position = new Transform[transform.childCount];
        int i = 0;
        foreach (Transform t in transform)
        {
            position[i++] = t;
            //result.Add(t.name);
           temp += t.name;
           
        }
    }

    public void EplSubmit()
    {
        Submit(); 
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("eplresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void LaSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("laresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void BundSubmit()
    {
        Submit(); 
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("bundresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void SaSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("saresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void SESubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("seresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void SLSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("slresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void SBSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("sbresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void SSSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("ssresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MESubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("meresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MLSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("mlresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MBSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("mbresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MSSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("msresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MTESubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("mteresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MLESubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("mleresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MTLSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("mtlresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MLLSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("mllresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MTBSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("mtbresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MLBSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("mlbresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MTSSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("mtsresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void MLSSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("mlsresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void STESubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("steresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void SLESubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("sleresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void STBSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("stbresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void SLBSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("slbresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void STLSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("stlresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void SLLSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("sllresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void STSSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("stsresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void SLSSubmit()
    {
        Submit();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("slsresult", temp);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    IEnumerator Submit(WWW w)
    {
        yield return w;    //WAIT FOR A RESPONSE FROM THE SERVER

        if (w.error == null)
        {

            loadingScreen.SetActive(false);
            playback.SetActive(true);
            if (w.text == "Submission successful!")
            {    
                print("Submission Successful");
            }
            //THE PHP SCRIPT SUPPLIED WILL TELL THE PLAYER IF THEIR PASSWORD IS INCORRECT, OR IF THEIR USERNAME DOESN'T EXIST
        }
        else
        {
            OkButton.SetActive(false);
            loadingScreen.SetActive(false);
            messageText.text = "ERROR: " + w.error;
        }//IF THERE IS AN ERROR (SUCH AS THE SERVER BEING DOWN) THE PHP SCRIPT SUPPLIED WILL TELL THE PLAYER
    }
}
