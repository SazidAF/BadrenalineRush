using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitHandler : MonoBehaviour
{
    //private bool hasPlayerEnter;

    void Start()
    {
        
    }


    void Update()
    {
        // if (hasPlayerEnter)
        //{
        //  if (Input.GetKey(KeyCode.E))
        // {
        //     GameManeger.instance.gotoLevelComplete();
        //}
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
            GameManeger.instance.gotoLevelComplete();
    }
    
    

}
