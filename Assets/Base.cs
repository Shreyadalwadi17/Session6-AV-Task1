using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Base : MonoBehaviour
{
    //[SerializeField] AudioSource bgaudiosource;
    public Canvas canbtn;
    public Canvas canvc;
    public Canvas canvs;
    public Canvas canv360;
    public VideoPlayer vcvp;
    public VideoPlayer vsvp;

    // Start is called before the first frame update
    void Start()
    {
        canbtn.enabled = true;
        canvc.enabled = false;
        canvs.enabled = false;
        canv360.enabled = false;

    }

    public void Oncanvc()
    {
        vcvp.Play();
        canbtn.enabled = false;
        canvc.enabled = true;
        canvs.enabled = false;
        canv360.enabled = false;
        AudioButton.inst.SoundPlay(AudioButton.SoundName.Sound1);


    }
    public void Oncanvs()
    {
        vsvp.Play();
        canbtn.enabled = false;
        canvc.enabled = false;
        canvs.enabled = true;
        canv360.enabled = false;
        AudioButton.inst.SoundPlay(AudioButton.SoundName.Sound2);

    }
    public void Oncanv360()
    {

        canbtn.enabled = false;
        canvc.enabled = false;
        canvs.enabled = false;
        canv360.enabled = true;
        AudioButton.inst.SoundPlay(AudioButton.SoundName.Sound3);

    }
    public void Onclosebtn()
    {
        vcvp.Stop();
        vsvp.Stop();
        canbtn.enabled = true;
        AudioButton.inst.SoundPlay(AudioButton.SoundName.Sound4);

    }


}
