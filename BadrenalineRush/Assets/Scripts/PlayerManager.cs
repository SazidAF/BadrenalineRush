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
    private float badrenalinePoint = 0;
    private bool baddable;
    public static PlayerManager instance;


    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("multiple player manager");
            return;
        }
        instance = this;
    }
    void Start()
    {
        respawnPoint = rb.transform.position;
        baddable = false;
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
        if(col.gameObject.tag == "FallDetector")
        {
            Invoke("Respawn", 0.25f);
        }
    }

    public void addBadrenaline()
    {
        badrenalinePoint += .2f;
    }
    public float getBadrenaline()
    {
       return badrenalinePoint;
    }
    
    public bool isBaddable()
    {
        if (badrenalinePoint >= .3f)
        {
            baddable = true;
        }
        return baddable;

    }

    public void setBaddableFalse()
    {
        baddable = false;
    }

    public void hasUsedBadrenaline()
    {
        badrenalinePoint -= .3f;
    }
    public void hasDoubleJumped(){
        badrenalinePoint -= .02f;
    }
    public bool canDoubleJump(){
        if(badrenalinePoint >= .02f){
            return true;
        }else
            return false;
    }
}
