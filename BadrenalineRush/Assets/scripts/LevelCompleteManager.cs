using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void changeScene(string name)
    {
        GameManeger.instance.sceneChanger(name);
    }

    public void restartScene()
    {
        GameManeger.instance.restartScene();
    }

    public void nextLev()
    {
        GameManeger.instance.nextLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
