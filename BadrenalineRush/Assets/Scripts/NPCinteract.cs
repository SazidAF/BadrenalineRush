using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCinteract : MonoBehaviour
{
    [SerializeField]
    private Animator boyAnim;
    [SerializeField]
    private Animator balloonAnim;
    [SerializeField]
    private BoxCollider2D boxCollider;
    private bool isPlayerHere;
    private bool hasPlayerBeenHere;
    void Start()
    {
        isPlayerHere = false;
        hasPlayerBeenHere = true;
    }

    private void killBoy()
    {
        boyAnim.SetBool("isBoyDead", true);
    }

    private void popBalloon()
    {
        balloonAnim.SetBool("isPop", true);
    }

    private void interaction()
    {
        killBoy();
        popBalloon();
        PlayerManager.instance.addBadrenaline();
        hasPlayerBeenHere = false;
        boxCollider.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerHere == true && Input.GetKey(KeyCode.E) && hasPlayerBeenHere)
        {
            interaction();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            isPlayerHere = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            isPlayerHere = false;
        }
    }

    /* private void OnTriggerStay2D(Collider2D collision)
     {

     }*/

}
