using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rbPlayer;
    private bool isGrounded = true;
    private float jumpForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        rbPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical");
        anim.SetFloat("speed", vertical);
        if (!isGrounded)
        {
            isGrounded = true;
            anim.SetBool("isGrounded", isGrounded);
        }
        Jump();

    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isGrounded = false;
            anim.SetBool("isGrounded", isGrounded);
            rbPlayer.velocity = Vector3.up * jumpForce;
        }
    }
}
