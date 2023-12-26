using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;

    public Sound[] clips;
    public static AudioButton inst;

    public void Awake()
    {
        inst = this;

    }

    public void SoundPlay(SoundName name)
    {
        foreach (var item in clips)
        {
            if (item.name == name)
            {
                audioSource.PlayOneShot(item.clip);
                break;
            }
        }

    }

    public void SoundMute(bool val)
    {
        audioSource.mute = val;

    }
    [System.Serializable]
    public class Sound
    {
        public SoundName name;
        public AudioClip clip;
    }
    public enum SoundName
    {
        Sound1,
        Sound2,
        Sound3,
        Sound4,


    }



}


