using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitHandler : MonoBehaviour
{
    private bool hasPlayerEnter;

    void Start()
    {
        
    }


    void Update()
    {
        if (hasPlayerEnter)
        {
            Debug.Log("Do somethiong");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
            hasPlayerEnter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
            hasPlayerEnter = false;
    }
}
