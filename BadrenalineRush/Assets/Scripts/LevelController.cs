using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelController : MonoBehaviour
{

    public List<Button> levels = new List<Button>();

    // Start is called before the first frame update
    void Start()
    {

    }

    void unlockLevlist()
    {
        for(int i = 0; i < levels.Count; i += 1)
        {
            levels[i].interactable = GameManeger.instance.isUnlockedLevel[i];
        }
    }

    public void changeScene(string name)
    {
        GameManeger.instance.sceneChanger(name);
    }


    // Update is called once per frame
    void Update()
    {
        unlockLevlist();
    }
}
