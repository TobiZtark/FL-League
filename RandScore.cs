using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

public class RandScore : MonoBehaviour {

    public GameObject loadingScreen;
    public GameObject submitScreen;
    public GameObject cancelButton;
    public GameObject OkButton;
    public GameObject playback;
    public Text messageText;
    public GameObject cardPrefab;
    public float cardOffset;
    public Vector3 start;
    public GameObject update;
    public GameObject proceed;
    string result;
    string username;

    public Text Score;
    public Text Score1;
    public Text Score2;
    public Text Score3;
    public Text Score4;
    public Text Score5;
    public Text Score6;
    public Text Score7;
    public Text Score8;
    public Text Score9;
    public Text Score10;
    public Text Score11;
    public Text Score12;
    public Text Score13;
    public Text Score14;
    public Text Score15;
    public Text Score16;
    public Text Score17;
    public Text Score18;
    public Text Score19;
    public Text Messagetext;

    float point, goal, position;
    float point1, goal1, position1;
    float point2, goal2, position2;
    float point3, goal3, position3;
    float point4, goal4, position4;
    float point5, goal5, position5;
    float point6, goal6, position6;
    float point7, goal7, position7;
    float point8, goal8, position8;
    float point9, goal9, position9;
    float point10, goal10, position10;
    float point11, goal11, position11;
    float point12, goal12, position12;
    float point13, goal13, position13;
    float point14, goal14, position14;
    float point15, goal15, position15;
    float point16, goal16, position16;
    float point17, goal17, position17;
    float point18, goal18, position18;
    float point19, goal19, position19;

    public void Awake()
    {
        username = PlayerPrefs.GetString("username");
        proceed.SetActive(false);
    }
    // Update is called once per frame
    public void GetFixtures() {
        int score = int.Parse(Score.text);
        int score1 = int.Parse(Score1.text);
        int score2 = int.Parse(Score2.text);
        int score3 = int.Parse(Score3.text);
        int score4 = int.Parse(Score4.text);
        int score5 = int.Parse(Score5.text);
        int score6 = int.Parse(Score6.text);
        int score7 = int.Parse(Score7.text);
        int score8 = int.Parse(Score8.text);
        int score9 = int.Parse(Score9.text);
        int score10 = int.Parse(Score10.text);
        int score11 = int.Parse(Score11.text);
        int score12 = int.Parse(Score12.text);
        int score13 = int.Parse(Score13.text);
        int score14 = int.Parse(Score14.text);
        int score15 = int.Parse(Score15.text);
        int score16 = int.Parse(Score16.text);
        int score17 = int.Parse(Score17.text);
        int score18 = int.Parse(Score18.text);
        int score19 = int.Parse(Score19.text);



        if (score > score1) {
            point = 3;
            point1 = 0;
            goal = (score - score1);
            goal1 = (score - score1);
            //Debug.Log("Team1 wins " + point + " points and " + goal + "goal difference");

        } else if (score == score1) {
            point = 1;
            point1 = 1;
            goal = (score - score1);
            goal1 = (score - score1);
           // Debug.Log("Its a Draw");

        } else if (score < score1)
        {
            point = 0;
            point1 = 3;
            goal = (score - score1);
            goal1 = (score1 - score);
           // Debug.Log("Team2 wins " + point1 + " points and " + goal1 + "goal difference");

        } else
            Messagetext.text = "Please enter a number between 0 and 99";

        if (score2 > score3) {
            point2 = 3;
            point3 = 0;
            goal2 = (score2 - score3);
            goal3 = (score2 - score3);
           // Debug.Log("Team1 wins " + point2 + " points and " + goal2 + "goal difference");

        } else if (score2 == score3) {
            point2 = 1;
            point3 = 1;
            goal2 = (score2 - score3);
            goal3 = (score2 - score3);
           // Debug.Log("Its a Draw");

        } else if (score2 < score3)
        {
            point2 = 0;
            point3 = 3;
            goal2 = (score2 - score3);
            goal3 = (score3 - score2);
            //Debug.Log("Team2 wins " + point3 + " points and " + goal3 + "goal difference");

        } else
            Messagetext.text = "Please enter a number between 0 and 99";

        if (score4 > score5) {
            point4 = 3;
            point5 = 0;
            goal4 = (score4 - score5);
            goal5 = (score4 - score5);
           // Debug.Log("Team1 wins " + point4 + " points and " + goal4 + "goal difference");

        } else if (score4 == score5) {
            point4 = 1;
            point5 = 1;
            goal4 = (score4 - score5);
            goal5 = (score4 - score5);
          //  Debug.Log("Its a Draw");

        } else if (score4 < score5)
        {
            point4 = 0;
            point5 = 3;
            goal4 = (score4 - score5);
            goal5 = (score5 - score4);
           // Debug.Log("Team2 wins " + point5 + " points and " + goal5 + "goal difference");

        } else
            Messagetext.text = "Please enter a number between 0 and 99";

        if (score6 > score7) {
            point6 = 3;
            point7 = 0;
            goal6 = (score6 - score7);
            goal7 = (score6 - score7);
           // Debug.Log("Team1 wins " + point6 + " points and " + goal6 + "goal difference");

        } else if (score6 == score7) {
            point6 = 1;
            point7 = 1;
            goal6 = (score6 - score7);
            goal7 = (score6 - score7);
          //  Debug.Log("Its a Draw");

        } else if (score6 < score7)
        {
            point6 = 0;
            point7 = 3;
            goal6 = (score6 - score7);
            goal7 = (score7 - score6);
          //  Debug.Log("Team2 wins " + point7 + " points and " + goal7 + "goal difference");

        } else
            Messagetext.text = "Please enter a number between 0 and 99";

        if (score8 > score9) {
            point8 = 3;
            point9 = 0;
            goal8 = (score8 - score9);
            goal9 = (score8 - score9);
          //  Debug.Log("Team1 wins " + point8 + " points and " + goal8 + "goal difference");

        } else if (score8 == score9) {
            point8 = 1;
            point9 = 1;
            goal8 = (score8 - score9);
            goal9 = (score8 - score9);
           // Debug.Log("Its a Draw");

        } else if (score8 < score9)
        {
            point8 = 0;
            point9 = 3;
            goal8 = (score8 - score9);
            goal9 = (score9 - score8);
          //  Debug.Log("Team2 wins " + point9 + " points and " + goal9 + "goal difference");

        } else
            Messagetext.text = "Please enter a number between 0 and 99";

        if (score10 > score11) {
            point10 = 3;
            point11 = 0;
            goal10 = (score10 - score11);
            goal11 = (score10 - score11);
         //   Debug.Log("Team1 wins " + point10 + " points and " + goal10 + "goal difference");

        } else if (score10 == score11) {
            point10 = 1;
            point11 = 1;
            goal10 = (score10 - score11);
            goal11 = (score10 - score11);
          //  Debug.Log("Its a Draw");

        } else if (score10 < score11)
        {
            point10 = 0;
            point11 = 3;
            goal10 = (score10 - score11);
            goal11 = (score11 - score10);
          //  Debug.Log("Team2 wins " + point11 + " points and " + goal11 + "goal difference");

        } else
            Messagetext.text = "Please enter a number between 0 and 99";

        if (score12 > score13) {
            point12 = 3;
            point13 = 0;
            goal12 = (score12 - score13);
            goal13 = (score12 - score13);
          //  Debug.Log("Team1 wins " + point12 + " points and " + goal13 + "goal difference");

        } else if (score12 == score13) {
            point12 = 1;
            point13 = 1;
            goal12 = (score12 - score13);
            goal13 = (score12 - score13);
          //  Debug.Log("Its a Draw");

        } else if (score12 < score13)
        {
            point12 = 0;
            point13 = 3;
            goal12 = (score12 - score13);
            goal13 = (score13 - score12);
          //  Debug.Log("Team2 wins " + point13 + " points and " + goal13 + "goal difference");

        } else
            Messagetext.text = "Please enter a number between 0 and 99";

        if (score14 > score15) {
            point14 = 3;
            point15 = 0;
            goal14 = (score14 - score15);
            goal15 = (score14 - score15);
          //  Debug.Log("Team1 wins " + point14 + " points and " + goal14 + "goal difference");

        } else if (score14 == score15) {
            point14 = 1;
            point15 = 1;
            goal14 = (score14 - score15);
            goal15 = (score14 - score15);
          //  Debug.Log("Its a Draw");

        } else if (score14 < score15)
        {
            point14 = 0;
            point15 = 3;
            goal14 = (score14 - score15);
            goal15 = (score15 - score14);
          //  Debug.Log("Team2 wins " + point15 + " points and " + goal15 + "goal difference");

        } else
            Messagetext.text = "Please enter a number between 0 and 99";

        if (score16 > score17) {
            point16 = 3;
            point17 = 0;
            goal16 = (score16 - score17);
            goal16 = (score16 - score17);
         //   Debug.Log("Team1 wins " + point16 + " points and " + goal16 + "goal difference");

        } else if (score16 == score17) {
            point16 = 1;
            point17 = 1;
            goal16 = (score16 - score17);
            goal17 = (score16 - score17);
          //  Debug.Log("Its a Draw");

        } else if (score16 < score17)
        {
            point16 = 0;
            point17 = 3;
            goal16 = (score16 - score17);
            goal17 = (score17 - score16);
          //  Debug.Log("Team2 wins " + point17 + " points and " + goal17 + "goal difference");

        } else
            Messagetext.text = "Please enter a number between 0 and 99";

        if (score18 > score19) {
            point18 = 3;
            point19 = 0;
            goal18 = (score18 - score19);
            goal19 = (score18 - score19);
         //   Debug.Log("Team1 wins " + point18 + " points and " + goal18 + "goal difference");

        } else if (score18 == score19) {
            point18 = 1;
            point19 = 1;
            goal18 = (score18 - score19);
            goal19 = (score18 - score19);
          //  Debug.Log("Its a Draw");

        } else if (score18 < score19)
        {
            point18 = 0;
            point19 = 3;
            goal18 = (score18 - score19);
            goal19 = (score19 - score18);
         //   Debug.Log("Team2 wins " + point19 + " points and " + goal19 + "goal difference");

        } else
            Messagetext.text = "Please enter a number between 0 and 99";

        position = point + goal + 0.21f;
        position1 = point1 + goal1 + 0.2f;
        position2 = point2 + goal2 + 0.19f;
        position3 = point3 + goal3 + 0.18f;
        position4 = point4 + goal4 + 0.17f;
        position5 = point5 + goal5 + 0.15f;
        position6 = point6 + goal6 + 0.14f;
        position7 = point7 + goal7 + 0.13f;
        position8 = point8 + goal8 + 0.12f;
        position9 = point9 + goal9 + 0.11f;
        position10 = point10 + goal10 + 0.10f;
        position11 = point11 + goal11 + 0.09f;
        position12 = point12 + goal12 + 0.08f;
        position13 = point13 + goal13 + 0.07f;
        position14 = point14 + goal14 + 0.06f;
        position15 = point15 + goal15 + 0.05f;
        position16 = point16 + goal16 + 0.04f;
        position17 = point17 + goal17 + 0.03f;
        position18 = point18 + goal18 + 0.02f;
        position19 = point19 + goal19 + 0.01f;

        var clubs = new Dictionary<float, int>();
        int cardCount = 0;
        clubs.Add(position, 0);
        clubs.Add(position1, 1);
        clubs.Add(position2, 2);
        clubs.Add(position3, 3);
        clubs.Add(position4, 4);
        clubs.Add(position5, 5);
        clubs.Add(position6, 6);
        clubs.Add(position7, 7);
        clubs.Add(position8, 8);
        clubs.Add(position9, 9);
        clubs.Add(position10, 10);
        clubs.Add(position11, 11);
        clubs.Add(position12, 12);
        clubs.Add(position13, 13);
        clubs.Add(position14, 14);
        clubs.Add(position15, 15);
        clubs.Add(position16, 16);
        clubs.Add(position17, 17);
        clubs.Add(position18, 18);
        clubs.Add(position19, 19);

        var list = clubs.Keys.ToList();
        list.Sort();
        list.Reverse();

        result = "";
        //  if (cardCopy == null)
        //  {
        foreach (var key in list)
        {
            float co = cardOffset * cardCount;
            GameObject cardCopy = (GameObject)Instantiate(cardPrefab);
            Vector3 temp = start + new Vector3(0f, co);
            cardCopy.transform.position = temp;

            CardModel cardModel = cardCopy.GetComponent<CardModel>();
            cardModel.cardIndex = clubs[key];
            cardModel.Show(true);
            cardCount++;
            result += clubs[key] + ",";
           
            //DontDestroyOnLoad(cardCopy);
          //  Debug.Log(key + " " + clubs[key]);
        }
        // }
        //  else
        // Destroy(cardCopy);
       
    
    }

    public void ClickSubmit()
    {

        submitScreen.SetActive(true);
    }

    public void ClickBack()
    {
        submitScreen.SetActive(false);

    }

    public void ClickUpdate()
    {
        if (Score.text == "" || Score1.text == "" || Score2.text == "" || Score3.text == "" || Score4.text == "" || Score5.text == "" || Score6.text == "" || Score7.text == "" || Score8.text == "" || Score9.text == "" || Score10.text == "" || Score11.text == "" || Score12.text == "" || Score13.text == "" || Score14.text == "" || Score15.text == "" || Score16.text == "" || Score17.text == "" || Score18.text == "" || Score19.text == "")
        {
            Messagetext.text = "Please enter a Score into all fixtures between 0 and 99";
        }
        else
        {
            proceed.SetActive(true);
            Messagetext.text = "Table according to your Fixtures";
            GetFixtures();
        }
    }// Use this for initialization
    public void EplRand()
    {
        loadingScreen.SetActive(true);
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("eplresult", result);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }

    public void LaRand()
    {
        loadingScreen.SetActive(true);
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("laresult", result);
        WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
        StartCoroutine(Submit(w));
    }


    public void BundRand()
{
        loadingScreen.SetActive(true);
        WWWForm form = new WWWForm();
    form.AddField("username", username);
    form.AddField("bundresult", result);
    WWW w = new WWW("http://loglords.uphero.com/save_result.php", form);
    StartCoroutine(Submit(w));
}
    
    public void SaRand()
{
        loadingScreen.SetActive(true);
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






