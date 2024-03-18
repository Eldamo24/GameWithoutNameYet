using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        StartCoroutine("JumpCoroutine");
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
     
    }

    IEnumerator JumpCoroutine()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            isGrounded = false;
            anim.SetBool("isGrounded", isGrounded);
            yield return new WaitForSeconds(5);
        }
    }
}
