using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(Deck))]

public class Deckview : MonoBehaviour
{
	Deck deck;
    public GameObject loadingScreen;
    public GameObject submitScreen;
    public GameObject cancelButton;
    public GameObject OkButton;
    public GameObject playback;
    public Text messageText;
    public Vector3 start;
	public float cardOffset;
	public GameObject cardPrefab;
    string result;
    string username;
    public GameObject proceed;
	// Use this for initialization
	void Start ()
	{
        
        username = PlayerPrefs.GetString("username");
        deck = GetComponent<Deck>();
		ShowCards1 ();
        proceed.SetActive(false);
    }

    public void ClickSubmit()
    {

        submitScreen.SetActive(true);
        //Debug.Log(result);
    }

    public void ClickBack()
    {
        submitScreen.SetActive(false);
       
    }

    void ShowCards()
	{
        proceed.SetActive(true);
        int cardCount = 0;
        result = "";
        foreach (int i in deck.GetCards()) {
			float co = cardOffset * cardCount;
			GameObject cardCopy = (GameObject)Instantiate(cardPrefab);
			Vector3 temp = start + new Vector3 (0f, co);
			cardCopy.transform.position = temp;

			CardModel cardModel = cardCopy.GetComponent<CardModel>();
			cardModel.cardIndex = i;
			cardModel.Show(true);
			cardCount++;
            result += i + ",";
        }
    }

    void ShowCards1()
    {
        int cardCount = 0;

        for (int i = 0; i < 20; i++)
        {
            float co = cardOffset * cardCount;
            GameObject cardCopy = (GameObject)Instantiate(cardPrefab);
            Vector3 temp = start + new Vector3(0f, co);
            cardCopy.transform.position = temp;

            CardModel cardModel = cardCopy.GetComponent<CardModel>();
            cardModel.cardIndex = i;
            cardModel.Show(true);

            cardCount++;
        }

    }

    public void Shuffler()
	{
        deck.Shuffle ();
		deck = GetComponent<Deck>();
        ShowCards();
       
    }

    public void EplSubmit()
    {
        loadingScreen.SetActive(true);
        ShowCards();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("eplresult", result);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void LaSubmit()
    {
        loadingScreen.SetActive(true);
        ShowCards();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("laresult", result);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void BundSubmit()
    {
        loadingScreen.SetActive(true);
        ShowCards();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("bundresult", result);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void SaSubmit()
    {
        loadingScreen.SetActive(true);
        ShowCards();
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("saresult", result);
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

