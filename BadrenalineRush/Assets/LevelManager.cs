using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private bool isPause;
    [SerializeField]
    private Canvas canvas;

    private void goPause()
    {
        isPause = !isPause;
        canvas.enabled = isPause;
    }
    // Start is called before the first frame update
    void Start()
    {
        isPause = canvas.enabled;
        canvas.enabled = false;
        isPause = canvas.enabled;
    }

    public void changeScene(string scene)
    {
        GameManeger.instance.sceneChanger(scene);
    }

    public void exitGame()
    {
        GameManeger.instance.exitGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            goPause();
        }
    }
}
