using UnityEngine;
using System.Collections;

public class OpenURL : MonoBehaviour {

	// Use this for initialization
	public void OpenSesame()
	{
		Application.OpenURL("www.instagram.com/uphero");
	}
}
