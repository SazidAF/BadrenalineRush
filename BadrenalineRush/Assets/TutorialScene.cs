using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScene : MonoBehaviour
{

    public void goBack(string name)
    {
        GameManeger.instance.sceneChanger(name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
