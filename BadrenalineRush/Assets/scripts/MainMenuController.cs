using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changeScene(string name)
    {
        GameManeger.instance.sceneChanger(name);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
