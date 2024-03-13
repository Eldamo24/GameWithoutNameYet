using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Animator variables")]
    private Animator playerAnimator;
    private int IdRunAnimation = Animator.StringToHash("Run");
    private int IdIdleAnimation = Animator.StringToHash("Idle");
    private int IdRunningJumpAnimation = Animator.StringToHash("RunningJump");
    private int IdStandingJumpAnimation = Animator.StringToHash("StandingJump");


    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {

    }

    private void Jump()
    {


    }
}
