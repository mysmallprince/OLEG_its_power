using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;

    public int score = 0;
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
    int sceneIndex;
    


    void Start()
    {
        PosJump = Jump.transform.position.y;
        PosBtnLeft = btnLeft.transform.position.y;
        PosBtnRight = btnRight.transform.position.y;
        PosBack = Back.transform.position.y;
        rb = GetComponent<Rigidbody2D>();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;

    }


    void Update()
    {

        if (transform.position.x < -23 || transform.position.x > 63 || transform.position.y < -6 || transform.position.y > 11 ){
            SceneManager.LoadScene (sceneIndex);
        }


        

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
    public void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("coin")){
            Destroy (other.gameObject);
            score++;
        }
    }
}
