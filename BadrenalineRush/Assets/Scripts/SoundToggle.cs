using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{

    public bool isSoundOn = true;
    [SerializeField]
    private RawImage rawImage;
    [SerializeField]
    private bool music;
    [SerializeField]
    private Texture soundOff;
    [SerializeField]
    private Texture soundOn;

    public void toggleSound()
    {
        
        isSoundOn = !isSoundOn;
        if (music)
        {
            SoundManager.instance.toggleSound();
        }
        changeSprite();

    }

    private void changeSprite()
    {
        if (isSoundOn)
        {
            rawImage.texture = soundOn; 
        } 
        else
        {
            rawImage.texture = soundOff;
        }
    }
}
