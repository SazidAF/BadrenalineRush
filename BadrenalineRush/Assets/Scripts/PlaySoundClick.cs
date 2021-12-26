using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundClick : MonoBehaviour
{

    [SerializeField] private AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void playOnclick()
    {
        SoundManager.instance.playSound(clip);
    }

}
