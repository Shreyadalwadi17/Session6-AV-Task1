using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class Video : MonoBehaviour
{
    public VideoPlayer vp;
    public Button ssbtn;
    public Image start;
    public Image stop;
    public AudioSource audiosource;
    public Slider vslide;
    public Text tt;


    public void Onssbtn()
    {
        if (vp.isPlaying == false)
        {
            vp.Play();
            start.enabled = true;
            stop.enabled = false;

        }
        else
        {
            vp.Pause();
            stop.enabled = true;
            start.enabled = false;
        }
    }
    public void Start()
    {
        vslide.value = 1;
    }
    public void Update()
    {
        audiosource.volume = vslide.value;
        double elapsedSeconds = vp.time;
        int elapsedMinutes = Mathf.FloorToInt((float)elapsedSeconds / 60);
        elapsedSeconds -= elapsedMinutes * 60;
        tt.text = string.Format("{0:00}:{1:00}", elapsedMinutes, (int)elapsedSeconds);
    }

    public void OnMute()
    {
        audiosource.mute = true;
    }
    public void OnUnmute()
    {
        audiosource.mute = false;
    }

    public void OnForward()
    {
        vp.time += 10f;
    }
    public void OnBackward()
    {
        vp.time -= 10f;
    }
    public void OnFastForward()
    {
        vp.time += 50f;
    }
    public void Onpluse()
    {
        audiosource.volume = vslide.value += 0.1f;
    }
    public void Onminus()
    {
        audiosource.volume = vslide.value -= 0.1f;
    }

}

