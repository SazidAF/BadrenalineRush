using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    public void startRunning()
    {
        animator.SetBool("isRunning", true);
    }

    public void stopRunning()
    {
        animator.SetBool("isRunning", false);
    }

    public void startJump()
    {
        animator.SetBool("isJumping", true);
    }

    public void stopJump()
    {
        animator.SetBool("isJumping", false);
    }

    public void goIdle(bool isGrounded)
    {
        animator.SetBool("isIdle", isGrounded);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
