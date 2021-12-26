using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField]
    private AudioSource musicSource, effectsSource;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void playSound(AudioClip clip)
    {
        effectsSource.PlayOneShot(clip);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
