﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    int selectidskin;
    public Sprite standart;
    public Sprite duck;
    public Sprite superduck;
    public SpriteRenderer sr;
    Rigidbody2D rb;
    public Text Money;
    int score;
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
        selectidskin = PlayerPrefs.GetInt("SelSkin");
        if(selectidskin == 0)
        {
            sr.sprite = standart;
        }
        if(selectidskin == 1)
        {
            sr.sprite = duck;
        }
        if(selectidskin == 2)
        {
            sr.sprite = superduck;
        }
        score = PlayerPrefs.GetInt("money");
        Money.text = score.ToString();
        if(Advertisement.isSupported)
        {
            Advertisement.Initialize("3959789");
        }
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
            Money.text = score.ToString();
            PlayerPrefs.SetInt("money", score);
        }
    }
}
