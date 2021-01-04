using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Shop : MonoBehaviour
{
    public Text DuckT;
    public int DuckM;
    public Text SupDuckT;
    public int SupDuckM;
    public Text MegaDuckT;
    public int MegaDuckM;
    public GameObject standart;
    public GameObject duck;
    public GameObject supduck;
    public GameObject megaduck;
    int selectidskin;
    int Standart;
    int Duck;
    int SupDuck;
    int MegaDuck;
    int coins;
    void Start()
    {
        coins = PlayerPrefs.GetInt("money");
        selectidskin = PlayerPrefs.GetInt("SelSkin");
        Standart = PlayerPrefs.GetInt("standart");
        Duck = PlayerPrefs.GetInt("duck");
        SupDuck = PlayerPrefs.GetInt("supduck");
        MegaDuck = PlayerPrefs.GetInt("megaduck");
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
        switch(SupDuck)
        {
            case 0:
                supduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                SupDuckT.text = SupDuckM.ToString();
                break;
            case 1:
                supduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                SupDuckT.text = "";
                break;
        }
        switch(MegaDuck)
        {
            case 0:
                megaduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                MegaDuckT.text = MegaDuckM.ToString();
                break;
            case 1:
                megaduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                MegaDuckT.text = "";
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
        else if(selectidskin == 2)
        {
            supduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
        }
        else if(selectidskin == 3)
        {
            megaduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
        }
    }
    public void Standarts()
    {
        PlayerPrefs.SetInt("SelSkin", 0);
        selectidskin = PlayerPrefs.GetInt("SelSkin");
        Standart = PlayerPrefs.GetInt("standart");
        Duck = PlayerPrefs.GetInt("duck");
        SupDuck = PlayerPrefs.GetInt("supduck");
        MegaDuck = PlayerPrefs.GetInt("megaduck");
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
        switch(SupDuck)
        {
            case 0:
                supduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                SupDuckT.text = SupDuckM.ToString();
                break;
            case 1:
                supduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                SupDuckT.text = "";
                break;
        }
        switch(MegaDuck)
        {
            case 0:
                megaduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                MegaDuckT.text = MegaDuckM.ToString();
                break;
            case 1:
                megaduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                MegaDuckT.text = "";
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
        else if(selectidskin == 2)
        {
            supduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
        }
        else if(selectidskin == 3)
        {
            megaduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
        }
    }
    public void Ducks()
    {
        if(coins >= DuckM && Duck != 1)
        {
            DuckT.text = "";
            //coins -= DuckM;
            PlayerPrefs.SetInt("money", coins);
            PlayerPrefs.SetInt("SelSkin", 1);
            PlayerPrefs.SetInt("duck", 1);
            selectidskin = PlayerPrefs.GetInt("SelSkin");
            Standart = PlayerPrefs.GetInt("standart");
            Duck = PlayerPrefs.GetInt("duck");
            SupDuck = PlayerPrefs.GetInt("supduck");
            MegaDuck = PlayerPrefs.GetInt("megaduck");
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
            switch(SupDuck)
            {
                case 0:
                    supduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    SupDuckT.text = SupDuckM.ToString();
                    break;
                case 1:
                    supduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    SupDuckT.text = "";
                    break;
            }
            switch(MegaDuck)
            {
                case 0:
                    megaduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    MegaDuckT.text = MegaDuckM.ToString();
                    break;
                case 1:
                    megaduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    MegaDuckT.text = "";
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
            else if(selectidskin == 2)
            {
                supduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            else if(selectidskin == 3)
            {
                megaduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            coins = PlayerPrefs.GetInt("money");
        }
        if(Duck == 1)
        {
            PlayerPrefs.SetInt("SelSkin", 1);
            selectidskin = PlayerPrefs.GetInt("SelSkin");
            Standart = PlayerPrefs.GetInt("standart");
            Duck = PlayerPrefs.GetInt("duck");
            SupDuck = PlayerPrefs.GetInt("supduck");
            MegaDuck = PlayerPrefs.GetInt("megaduck");
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
            switch(SupDuck)
            {
                case 0:
                    supduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    SupDuckT.text = SupDuckM.ToString();
                    break;
                case 1:
                    supduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    SupDuckT.text = "";
                    break;
            }
            switch(MegaDuck)
            {
                case 0:
                    megaduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    MegaDuckT.text = MegaDuckM.ToString();
                    break;
                case 1:
                    megaduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    MegaDuckT.text = "";
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
            else if(selectidskin == 2)
            {
                supduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            else if(selectidskin == 3)
            {
                megaduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
        }
    }
    public void SupDucks()
    {
        if(coins >= SupDuckM && SupDuck != 1)
        {
            SupDuckT.text = "";
            //coins -= SupDuckM;
            PlayerPrefs.SetInt("money", coins);
            PlayerPrefs.SetInt("SelSkin", 2);
            PlayerPrefs.SetInt("supduck", 1);
            selectidskin = PlayerPrefs.GetInt("SelSkin");
            Standart = PlayerPrefs.GetInt("standart");
            Duck = PlayerPrefs.GetInt("duck");
            SupDuck = PlayerPrefs.GetInt("supduck");
            MegaDuck = PlayerPrefs.GetInt("megaduck");
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
            switch(SupDuck)
            {
                case 0:
                    supduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    SupDuckT.text = SupDuckM.ToString();
                    break;
                case 1:
                    supduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    SupDuckT.text = "";
                    break;
            }
            switch(MegaDuck)
            {
                case 0:
                    megaduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    MegaDuckT.text = MegaDuckM.ToString();
                    break;
                case 1:
                    megaduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    MegaDuckT.text = "";
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
            else if(selectidskin == 2)
            {
                supduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            else if(selectidskin == 3)
            {
                megaduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            coins = PlayerPrefs.GetInt("money");
        }
        if(SupDuck == 1)
        {
            PlayerPrefs.SetInt("SelSkin", 2);
            selectidskin = PlayerPrefs.GetInt("SelSkin");
            Standart = PlayerPrefs.GetInt("standart");
            Duck = PlayerPrefs.GetInt("duck");
            SupDuck = PlayerPrefs.GetInt("supduck");
            MegaDuck = PlayerPrefs.GetInt("megaduck");
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
            switch(SupDuck)
            {
                case 0:
                    supduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    SupDuckT.text = SupDuckM.ToString();
                    break;
                case 1:
                    supduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    SupDuckT.text = "";
                    break;
            }
            switch(MegaDuck)
            {
                case 0:
                    megaduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    MegaDuckT.text = MegaDuckM.ToString();
                    break;
                case 1:
                    megaduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    MegaDuckT.text = "";
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
            else if(selectidskin == 2)
            {
                supduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            else if(selectidskin == 3)
            {
                megaduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
        }
    }

    public void MegaDucks()
    {
        if(coins >= MegaDuckM && MegaDuck != 1)
        {
            MegaDuckT.text = "";
            //coins -= SupDuckM;
            PlayerPrefs.SetInt("money", coins);
            PlayerPrefs.SetInt("SelSkin", 3);
            PlayerPrefs.SetInt("megaduck", 1);
            selectidskin = PlayerPrefs.GetInt("SelSkin");
            Standart = PlayerPrefs.GetInt("standart");
            Duck = PlayerPrefs.GetInt("duck");
            SupDuck = PlayerPrefs.GetInt("supduck");
            MegaDuck = PlayerPrefs.GetInt("megaduck");
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
            switch(SupDuck)
            {
                case 0:
                    supduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    SupDuckT.text = SupDuckM.ToString();
                    break;
                case 1:
                    supduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    SupDuckT.text = "";
                    break;
            }
            switch(MegaDuck)
            {
                case 0:
                    megaduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    MegaDuckT.text = MegaDuckM.ToString();
                    break;
                case 1:
                    megaduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    MegaDuckT.text = "";
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
            else if(selectidskin == 2)
            {
                supduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            else if(selectidskin == 3)
            {
                megaduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            coins = PlayerPrefs.GetInt("money");
        }
        if(MegaDuck == 1)
        {
            PlayerPrefs.SetInt("SelSkin", 3);
            selectidskin = PlayerPrefs.GetInt("SelSkin");
            Standart = PlayerPrefs.GetInt("standart");
            Duck = PlayerPrefs.GetInt("duck");
            SupDuck = PlayerPrefs.GetInt("supduck");
            MegaDuck = PlayerPrefs.GetInt("megaduck");
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
            switch(SupDuck)
            {
                case 0:
                    supduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    SupDuckT.text = SupDuckM.ToString();
                    break;
                case 1:
                    supduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    SupDuckT.text = "";
                    break;
            }
            switch(MegaDuck)
            {
                case 0:
                    megaduck.GetComponent<Image>().color = new Color(43/255.0f, 255/255.0f, 4/255.0f);
                    MegaDuckT.text = MegaDuckM.ToString();
                    break;
                case 1:
                    megaduck.GetComponent<Image>().color = new Color(238/255.0f, 255/255.0f, 0/255.0f);
                    MegaDuckT.text = "";
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
            else if(selectidskin == 2)
            {
                supduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
            else if(selectidskin == 3)
            {
                megaduck.GetComponent<Image>().color = new Color(0/255.0f, 29/255.0f, 255/255.0f);
            }
        }
    }

    
    public void GotoMenu()
    {
        SceneManager.LoadScene("Index");
    }
}
