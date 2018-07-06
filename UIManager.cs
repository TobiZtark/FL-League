using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {
	public GameObject PlayCanvas;
	public GameObject OnlineCanvas;
	public GameObject CustCanvas;
	public GameObject LeadCanvas;
	public GameObject HomeCanvas;

   public void DisableAnim(Animator anim)
	{
		anim.SetBool ("IsDisplayed", false);
	}

	public void EnableAnim(Animator anim)
	{
		anim.SetBool ("IsDisplayed", true);
	}
    
	public void OnPlay()
	{

            HomeCanvas.SetActive (false);
			PlayCanvas.SetActive (true);
			OnlineCanvas.SetActive (false);
			CustCanvas.SetActive (false);
			LeadCanvas.SetActive (false);
		}


	public void OnCust()
	{

        HomeCanvas.SetActive(false);
		PlayCanvas.SetActive(false);
		OnlineCanvas.SetActive(false);
		CustCanvas.SetActive(true);
		LeadCanvas.SetActive(false);

	}

	public void OnHome()
	{

        HomeCanvas.SetActive(true);
		PlayCanvas.SetActive(false);
		OnlineCanvas.SetActive(false);
		CustCanvas.SetActive(false);
		LeadCanvas.SetActive(false);

	}

	public void OnLead()
	{

        HomeCanvas.SetActive(false);
		PlayCanvas.SetActive(false);
		OnlineCanvas.SetActive(false);
		CustCanvas.SetActive(false);
		LeadCanvas.SetActive(true);

	}

	public void OnOnline()
	{

        HomeCanvas.SetActive (false);
			PlayCanvas.SetActive (false);
			OnlineCanvas.SetActive (true);
			CustCanvas.SetActive (false);
			LeadCanvas.SetActive (false);
		
	}

}
