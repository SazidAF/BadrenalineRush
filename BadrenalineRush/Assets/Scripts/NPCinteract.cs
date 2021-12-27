using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCinteract : MonoBehaviour
{
    [SerializeField]
    private Animator boyAnim;
    [SerializeField]
    private Animator balloonAnim;
    private bool isPlayerHere;
    void Start()
    {
        isPlayerHere = false;
    }

    private void killBoy()
    {
        boyAnim.SetBool("isBoyDead", true);
    }

    private void popBalloon()
    {
        balloonAnim.SetBool("isPop", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerHere == true && Input.GetKey(KeyCode.E))
        {
            killBoy();
            popBalloon();
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
