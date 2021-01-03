using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shop : MonoBehaviour
{
    public Text DuckT;
    public int DuckM;
    public GameObject standart;
    public GameObject duck;
    int selectidskin;
    int Standart;
    int Duck;
    int coins;
    void Start()
    {
        coins = PlayerPrefs.GetInt("money");
        selectidskin = PlayerPrefs.GetInt("SelSkin");
        Standart = PlayerPrefs.GetInt("standart");
        Duck = PlayerPrefs.GetInt("duck");
        switch(Standart)
        {
            case 0:
                standart.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                break;
        }
        switch(Duck)
        {
            case 0:
                duck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                DuckT.text = DuckM.ToString();
                break;
            case 1:
                duck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                DuckT.text = "";
                break;
        }
        if(selectidskin == 0)
        {
            standart.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
        }
        else if(selectidskin == 1)
        {
            duck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
        }
    }
    public void Standarts()
    {
        PlayerPrefs.SetInt("SelSkin", 0);
        selectidskin = PlayerPrefs.GetInt("SelSkin");
        Standart = PlayerPrefs.GetInt("standart");
        Duck = PlayerPrefs.GetInt("duck");
        switch(Standart)
        {
            case 0:
                standart.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                break;
        }
        switch(Duck)
        {
            case 0:
                duck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                DuckT.text = DuckM.ToString();
                break;
            case 1:
                duck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                DuckT.text = "";
                break;
        }
        if(selectidskin == 0)
        {
            standart.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
        }
        else if(selectidskin == 1)
        {
            duck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
        }
    }
    public void Ducks()
    {
        if(coins > DuckM && Duck != 1)
        {
            DuckT.text = "";
            //coins -= DuckM;
            PlayerPrefs.SetInt("money", coins);
            PlayerPrefs.SetInt("SelSkin", 1);
            PlayerPrefs.SetInt("duck", 1);
            selectidskin = PlayerPrefs.GetInt("SelSkin");
            Standart = PlayerPrefs.GetInt("standart");
            Duck = PlayerPrefs.GetInt("duck");
            switch(Standart)
            {
            case 0:
                standart.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                break;
            }
            switch(Duck)
            {
                case 0:
                    duck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    break;
                case 1:
                    duck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 255/255.0f);
                    break;
            }   
            if(selectidskin == 0 && Standart == 0)
            {
                standart.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            else if(selectidskin == 1 && Duck == 1)
            {
                duck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            coins = PlayerPrefs.GetInt("money");
        }
        if(Duck == 1)
        {
            PlayerPrefs.SetInt("SelSkin", 1);
            selectidskin = PlayerPrefs.GetInt("SelSkin");
            Standart = PlayerPrefs.GetInt("standart");
            Duck = PlayerPrefs.GetInt("duck");
            switch(Standart)
            {
                case 0:
                    standart.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    break;
            }
            switch(Duck)
            {
                case 0:
                    duck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    DuckT.text = DuckM.ToString();
                    break;
                case 1:
                    duck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    DuckT.text = "";
                    break;
            }
            if(selectidskin == 0)
            {
                standart.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            else if(selectidskin == 1)
            {
                duck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
        }
    }

    
    void Update()
    {
        
    }
}
