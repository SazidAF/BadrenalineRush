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
        GameManeger.sceneChanger(name);
    }

    public void restartScene()
    {
        GameManeger.restartScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
