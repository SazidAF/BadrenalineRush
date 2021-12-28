using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{

    public static GameManeger instance;
    // Start is called before the first frame update
    public int totalLev;
    private int currentLev = 1;
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
        isUnlockedLevel[currentLev-1] = true;
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
        GameManeger.instance.sceneChanger(currentLev.ToString());
        //sceneChanger("lev" + instance.currentLev);
        Debug.Log(currentLev);
    }

    public void nextLevel()
    {
        Debug.Log(isUnlockedLevel.Length);
        Debug.Log(currentLev);
        if (isUnlockedLevel.Length > currentLev)
        {
            currentLev += 1;
            GameManeger.instance.sceneChanger(currentLev.ToString());
            isUnlockedLevel[currentLev - 1] = true;
        }
        else
        {
            Debug.Log(currentLev);
        }

    }

    public void gotoLevelComplete()
    {
        GameManeger.instance.sceneChanger("LevelComplete");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}


