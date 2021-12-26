using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSlide : MonoBehaviour
{
    [SerializeField] private Slider slider;
    // Start is called before the first frame update


    void Start()
    {
        slider.onValueChanged.AddListener(val => SoundManager.instance.changeMasterVolume(val));
    }

    
}
