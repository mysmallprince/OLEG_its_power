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
	float p;


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
			k = ((transform.rotation.z < -100 && transform.rotation.z > -180) || (transform.rotation.z > 100 && transform.rotation.z < 180 ) && (transform.rotation.z < 1 && transform.rotation.z > 80) || (transform.rotation.z > -1 && transform.rotation.z < -80 )) ? 2f : -2f;
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
