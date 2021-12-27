using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Transform playerPos;
    public int dangerLayer;
    public Rigidbody2D rb;
    public Transform groundCheck;
    public PlayerAnimationController pAnimCtrl;
    private Vector3 respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = rb.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.T)){
          Die();
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(LayerMask.NameToLayer("Danger"));
        //Debug.Log(collision.gameObject.layer);
        if(collision.gameObject.layer == dangerLayer)
        {
        //Debug.Log(collision.gameObject.layer);

            Die();
        }
    }
    

    public void Die()
    {
            // Animation play
            pAnimCtrl.startDeath();
            // respawn
            GetComponent<PlayerMovement>().enabled = false;
            Invoke("Respawn", 2.0f);
    }
    public void Respawn()
    {
        pAnimCtrl.stopDeath();

        rb.transform.position = respawnPoint;
        GetComponent<PlayerMovement>().enabled = true;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "CheckPoint")
        {
            respawnPoint = rb.transform.position;
            Debug.Log(respawnPoint);
        }
    }
}
