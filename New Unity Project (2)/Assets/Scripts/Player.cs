using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;


    public GameObject btnLeft;
    public GameObject btnRight;
    float PosBtnLeft;
    float PosBtnRight;
    float run;


    void Start()
    {

        PosBtnLeft = btnLeft.transform.position.y;
        PosBtnRight = btnRight.transform.position.y;
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
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
