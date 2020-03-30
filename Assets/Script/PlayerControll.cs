using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpScale;
    [SerializeField] private VariableJoystick variableJoystick;
    [SerializeField] private LayerMask whatIsGround;
    GameControll gamecontroll;

    Transform groundCheck;
    bool grounded = false;
    Animator animator;

    private void Start()
    {
        groundCheck = transform.Find("GroundCheck");
        animator = GetComponent<Animator>();
        gamecontroll = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControll>();
    }

    private void FixedUpdate()
    {
        if (!gamecontroll.isGameOver())
        {
            grounded = Physics2D.OverlapCircle(groundCheck.position, 1.4f, whatIsGround);
            animator.SetBool("Ground", grounded);
            Move();
        }
    }

    void Move()
    {
        if (variableJoystick.Horizontal == 0)
        {
            animator.SetBool("Run", false);
        }
        else
        {
            animator.SetBool("Run", true);
            // 方向
            if (variableJoystick.Horizontal > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            // 移動
            GetComponent<Rigidbody2D>().velocity = new Vector2(variableJoystick.Horizontal * speed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            grounded = false;
            animator.SetBool("Ground", grounded);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpScale));
        }
    }
}
