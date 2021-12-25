using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changeScene(string name)
    {
        GameManeger.sceneChanger(name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
