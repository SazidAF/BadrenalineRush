using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{

    public void changeScene(string name)
    {
        GameManeger.instance.sceneChanger(name);
    }
}
