using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioSource bgmAudio;
    public AudioSource shootAudio;
    public AudioSource winAudio;
    public AudioSource failedAduio;
    // Use this for initialization


    public void playShootAudio()
    {
        shootAudio.Play();
    }
    public void stopShootAudio()
    {
        shootAudio.Stop();
    }
    public void playWinAudio()
    {
        winAudio.Play();
    }
    public void stopWinAudio()
    {
        winAudio.Stop();
    }
    public void playFailedAudio()
    {
        failedAduio.Play();
    }
    public void stopFailedAudio()
    {
        failedAduio.Stop();
    }
    public void stopBgmAduio()
    {
        bgmAudio.Stop();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
