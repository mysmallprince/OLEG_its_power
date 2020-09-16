using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;


    public GameObject btnLeft;
    public GameObject btnRight;
    public GameObject Jump;
    float PosJump;
    float PosBtnLeft;
    float PosBtnRight;
    float run;
    float k;


    void Start()
    {
        PosJump = Jump.transform.position.y;
        PosBtnLeft = btnLeft.transform.position.y;
        PosBtnRight = btnRight.transform.position.y;
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {

        if (PosJump != Jump.transform.position.y)
        {
            k = ((transform.localEulerAngles.z < 45) || (transform.localEulerAngles.z > -45)) ? -1f : 1f;
            k = ((transform.localEulerAngles.z > 60) || (transform.localEulerAngles.z < -60)) ? -1f : 1f;
            rb.AddForce(transform.up * k, ForceMode2D.Impulse);
        }



        if (PosBtnLeft != btnLeft.transform.position.y)
        {
            run = -3f;
        }

        else if (PosBtnRight != btnRight.transform.position.y)
        {
            run = 3f;
        }

        else
        {
            run = 0f;
        }

        rb.velocity = new Vector2(run, rb.velocity.y);
    }
}
