using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPPlay : MonoBehaviour {

    AudioSource MpPlayer;
   public AudioClip FirstClip;
    // Use this for initialization
    void Start()
    {
        MpPlayer.clip = FirstClip;
        MpPlayer.loop = false;
        MpPlayer.Play();
        StartCoroutine(WaitForTrackTOend());
    }

    IEnumerator WaitForTrackTOend()
    {
        while (MpPlayer.isPlaying)
        {

            yield return new WaitForSeconds(0.01f);

        }
        MpPlayer.clip = FirstClip;
        MpPlayer.loop = true;
        MpPlayer.Play();

    }
}
