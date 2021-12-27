using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject cage;
    [SerializeField]
    private Animator cageAnim;

    private bool playerEntered = false;
    
    void Start()
    {
        
    }

    private void destroyCage()
    {
        Destroy(cage);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(playerEntered && Input.GetKey(KeyCode.E))
        {
            cageAnim.SetBool("goFade", true);
            Invoke("destroyCage", 2f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            playerEntered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerEntered = false;
        }
    }
}
