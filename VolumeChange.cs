using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour {
    public Slider volSlid;
    public Slider volSlider;
    public Slider volSlid2;
    public AudioSource volSlide;
    public AudioSource volSlidee;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnValueChanged()
    {
        AudioListener.volume = volSlid.value;
        PlayerPrefs.SetFloat("volSlid", volSlid.value);
    }

    public void OnValueChanged2()
    {
        volSlide.volume = volSlider.value;
        PlayerPrefs.SetFloat("volSlider", volSlider.value);
    }

    public void OnValueChanged3()
    {
        volSlidee.volume = volSlid2.value;
        PlayerPrefs.SetFloat("volSlid2", volSlid2.value);
    }

    
}
