using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;


    public GameObject btnLeft;
    public GameObject btnRight;
    public GameObject Jump;
    public GameObject Back;
    float PosBack;
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
        PosBack = Back.transform.position.y;
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {

        if (PosBack != Back.transform.position.y){

            SceneManager.LoadScene("Index");
        }

        if (PosJump != Jump.transform.position.y)
        {
			k = ((transform.rotation.z < -100 && transform.rotation.z > -180) || (transform.rotation.z > 100 && transform.rotation.z < 180 )) ? -3f : 3f;
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
