using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{

    public static GameManeger instance;
    // Start is called before the first frame update
    public int totalLev;
    public int currentLev = 1;
    public bool[] isUnlockedLevel;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void initiateLevlist()
    {
        for(int i = 0; i < totalLev; i++)
        {
            isUnlockedLevel[i] = false;
        }
    } 
    void Start()
    {
        isUnlockedLevel = new bool[totalLev];
        initiateLevlist();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  sceneChanger(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void restartScene()
    {

        //SceneManager.LoadScene(currentLevel.name);
        GameManeger.instance.sceneChanger("lev" + currentLev);
        //sceneChanger("lev" + instance.currentLev);
    }

    public void nextLevel()
    {
        currentLev += 1;
        GameManeger.instance.sceneChanger("lev" + currentLev);
        Debug.Log(currentLev);

    }

    public void exitGame()
    {
        Application.Quit();
    }
}


