using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;

    [SerializeField] PlayerAnimationController animController;

    public bool doublejump;
    private float horizontal;
    public float speed = 8f;
    public float jumpForce = 13f;
    private bool isFacingRight = true;

    void Update()
    {
        if(IsGrounded() && !Input.GetButton("Jump"))
        {
            doublejump = false;
            animController.stopJump();
        }
        if (!isFacingRight && horizontal > 0f)
        {
            Flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            Flip();
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && (IsGrounded() || doublejump))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            animController.startJump();
            doublejump = !doublejump;
        }

        if (context.canceled && rb.velocity.y > 0f)
        {
           rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    public void Move(InputAction.CallbackContext context)
    {
        animController.startRunning();
        horizontal = context.ReadValue<Vector2>().x;
        if (context.canceled)
        {
            animController.stopRunning();
        }
    }
}
