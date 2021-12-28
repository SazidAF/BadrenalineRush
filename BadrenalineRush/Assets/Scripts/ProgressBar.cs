using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    private ParticleSystem particleSys;

    public float fillSpeed = 0.5f;
    private float targetProgress = 0;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        particleSys = GameObject.Find("ProgressBar Particles").GetComponent<ParticleSystem>();
    }
    // Start is called before the first frame update

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        targetProgress = PlayerManager.instance.getBadrenaline();
        if(slider.value < targetProgress)
        {
            slider.value += fillSpeed * Time.deltaTime;
            if(!particleSys.isPlaying)
            {
                particleSys.Play();
            }
        }else if(slider.value > targetProgress)
        {
            slider.value -= fillSpeed * Time.deltaTime;
            if(!particleSys.isPlaying)
            {
                particleSys.Play();
            }
        }else
        {
            particleSys.Stop();
        }

    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }

    public void DecrementProgress(float newProgress)
    {
        targetProgress = slider.value - newProgress;
    }
}
