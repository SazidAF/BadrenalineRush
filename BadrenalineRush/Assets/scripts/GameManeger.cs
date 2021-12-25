using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{

    public static GameManeger instance;
    // Start is called before the first frame update


    private void Awake()
    {
        if(instance == null)
            instance = this; 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void  sceneChanger(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public static void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
public enum Gamestate
{
    nextLevel,
    levelComplete,
    lose,
}