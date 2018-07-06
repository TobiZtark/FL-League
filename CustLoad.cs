using UnityEngine;
using UnityEngine.SceneManagement;

public class CustLoad : MonoBehaviour {

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Profile()
    {
        SceneManager.LoadScene("Profile");
    }

    public void Archive()
    {
        SceneManager.LoadScene("Archive");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits2");
    }
}
