using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderBoardLink : MonoBehaviour {

    // Use this for initialization
    public void Superboard()
    {
        SceneManager.LoadScene("Superboard");
    }

    public void Premierboard()
    {
        SceneManager.LoadScene("PremierLeagueLeader");
    }

    public void LAboard()
    {
        SceneManager.LoadScene("LaligaLeaderBoard");
    }

    public void BUboard()
    {
        SceneManager.LoadScene("BundesligaLeader");
    }

    public void SAboard()
    {
        SceneManager.LoadScene("SerieALeaderboard");
    }

    public void Sboard()
    {
        SceneManager.LoadScene("SpecialsLeader");
    }
}
