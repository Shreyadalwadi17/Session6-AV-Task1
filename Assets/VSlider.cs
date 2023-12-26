using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class VSlider : MonoBehaviour, IPointerDownHandler, IPointerUpHandler

{
    public VideoPlayer svp;
    Slider slide;
    bool slider = false;

    private void Start()
    {
        slide = GetComponent<Slider>();
    }
    public void Update()
    {
        if (!slider)
        {
            slide.value = (float)svp.frame / (float)svp.frameCount;
        }

    }
    public void OnPointerDown(PointerEventData eventdata)
    {
        slider = true;
        svp.Pause();
    }
    public void OnPointerUp(PointerEventData eventdata)
    {
        float frame = (float)slide.value * (float)svp.frameCount;
        svp.frame = (long)frame;
        slider = false;
        svp.Play();
    }

}
