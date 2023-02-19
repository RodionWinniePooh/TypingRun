using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    int Coin;
    int Dollar;
    int LevelNum;

    public GameObject ButtonItem1;
    public GameObject ButtonItem2;
    public GameObject ButtonItem3;

    public GameObject ButtonItem4;
    public GameObject ButtonItem5;
    public GameObject ButtonItem6;
    public GameObject ButtonItem7;
    public GameObject ButtonItem8;

    // Start is called before the first frame update
    void Start()
    {
        Coin = PlayerPrefs.GetInt("Coins");

        if (PlayerPrefs.GetInt("ButtonItem1") == 1 || PlayerPrefs.GetInt("ButtonItem1") == 0)
        {
            ButtonItem1.SetActive(false);
        }

        if (PlayerPrefs.GetInt("ButtonItem2") == 1 || PlayerPrefs.GetInt("ButtonItem2") == 0)
        {
            ButtonItem2.SetActive(false);
        }        
        
        if (PlayerPrefs.GetInt("ButtonItem3") == 1 || PlayerPrefs.GetInt("ButtonItem3") == 0)
        {
            ButtonItem3.SetActive(false);
        }








        if (Coin >= 1000 && PlayerPrefs.GetInt("ButtonItem1") == 0)
        {
            ButtonItem1.SetActive(true);
        }

        if (Coin >= 2000 && PlayerPrefs.GetInt("ButtonItem2") == 0)
        {
            ButtonItem2.SetActive(true);
        }        
        
        if (Coin >= 3000 && PlayerPrefs.GetInt("ButtonItem3") == 0)
        {
            ButtonItem3.SetActive(true);
        }








        LevelNum = PlayerPrefs.GetInt("levelNum");

        if (PlayerPrefs.GetInt("ButtonItem4") == 1 || PlayerPrefs.GetInt("ButtonItem4") == 0)
        {
            ButtonItem4.SetActive(false);
        }        
        
        if (PlayerPrefs.GetInt("ButtonItem5") == 1 || PlayerPrefs.GetInt("ButtonItem5") == 0)
        {
            ButtonItem5.SetActive(false);
        }  
        
        if (PlayerPrefs.GetInt("ButtonItem6") == 1 || PlayerPrefs.GetInt("ButtonItem6") == 0)
        {
            ButtonItem6.SetActive(false);
        }        
        
        if (PlayerPrefs.GetInt("ButtonItem7") == 1 || PlayerPrefs.GetInt("ButtonItem7") == 0)
        {
            ButtonItem7.SetActive(false);
        }        
        
        if (PlayerPrefs.GetInt("ButtonItem8") == 1 || PlayerPrefs.GetInt("ButtonItem8") == 0)
        {
            ButtonItem8.SetActive(false);
        }


        if (LevelNum >= 5 && PlayerPrefs.GetInt("ButtonItem4") == 0)
        {
            ButtonItem4.SetActive(true);
        }        
        
        if (LevelNum >= 10 && PlayerPrefs.GetInt("ButtonItem5") == 0)
        {
            ButtonItem5.SetActive(true);
        }        
        
        if (LevelNum >= 15 && PlayerPrefs.GetInt("ButtonItem6") == 0)
        {
            ButtonItem6.SetActive(true);
        }        
        
        if (LevelNum >= 20 && PlayerPrefs.GetInt("ButtonItem7") == 0)
        {
            ButtonItem7.SetActive(true);
        }        
        
        if (LevelNum >= 30 && PlayerPrefs.GetInt("ButtonItem8") == 0)
        {
            ButtonItem8.SetActive(true);
        }










    }

    public void ButtonItemFirst()
    {
        ButtonItem1.SetActive(false);
        PlayerPrefs.SetInt("ButtonItem1",1);
        PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + 10);
    }

    public void ButtonItemSecond()
    {
        ButtonItem2.SetActive(false);
        PlayerPrefs.SetInt("ButtonItem2", 1); //если 1 то награда получена
        PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + 20);
        PlayerPrefs.Save();
    }

    public void ButtonItemThird()
    {
        ButtonItem3.SetActive(false);
        PlayerPrefs.SetInt("ButtonItem3", 1); //если 1 то награда получена
        PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + 20);
        PlayerPrefs.Save();
    }

    public void ButtonItemFour()
    {
        ButtonItem4.SetActive(false);
        PlayerPrefs.SetInt("ButtonItem4", 1); //если 1 то награда получена
        PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + 10);
        PlayerPrefs.Save();
    }    
    
    public void ButtonItemFive()
    {
        ButtonItem5.SetActive(false);
        PlayerPrefs.SetInt("ButtonItem5", 1); //если 1 то награда получена
        PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + 30);
        PlayerPrefs.Save();
    }    
    
    public void ButtonItemSix()
    {
        ButtonItem6.SetActive(false);
        PlayerPrefs.SetInt("ButtonItem6", 1); //если 1 то награда получена
        PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + 50);
        PlayerPrefs.Save();
    }    
    public void ButtonItemSeven()
    {
        ButtonItem7.SetActive(false);
        PlayerPrefs.SetInt("ButtonItem7", 1); //если 1 то награда получена
        PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + 100);
        PlayerPrefs.Save();
    }    
    
    public void ButtonItemEight()
    {
        ButtonItem4.SetActive(false);
        PlayerPrefs.SetInt("ButtonItem8", 1); //если 1 то награда получена
        PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + 200);
        PlayerPrefs.Save();
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
