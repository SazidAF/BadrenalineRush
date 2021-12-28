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
        cage.GetComponent<BoxCollider2D>().enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(playerEntered && Input.GetKeyDown(KeyCode.E) && PlayerManager.instance.isBaddable())
        {
            PlayerManager.instance.setBaddableFalse();
            PlayerManager.instance.hasUsedBadrenaline();
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
