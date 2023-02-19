using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;


public class WinLoseCoins : MonoBehaviour //Класс для вывода заработанных монет (на сцене конца уровня)
{

    public Text coins;
    public Text speed; //количество набранных символов
    public GameObject buttonWin;
    public GameObject buttonLose;
    public GameObject BtnVideoX2;
    private bool first;


    // Start is called before the first frame update
    void Start()
    {
        string lang = PlayerPrefs.GetString("_language", "ru");
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3860681", false);
        }

        if (PlayerPrefs.GetInt("Win") == 1)
        {
            PlayerPrefs.SetInt("winCount", PlayerPrefs.GetInt("winCount") + 1);
            if(PlayerPrefs.GetInt("winCount")==3)
                if (Advertisement.IsReady())
                {
                    PlayerPrefs.SetInt("winCount", 0);
                    Advertisement.Show("video");
                }
            buttonLose.SetActive(false);
            buttonWin.SetActive(true);

            if (PlayerPrefs.GetInt("FirstTime") == 0) { 
                PlayerPrefs.SetInt("FirstTime", 1);
                if (lang == "ru")
                    coins.text = "Заработано:" + PlayerPrefs.GetInt("currCoins").ToString();
                else coins.text = "Earned:" + PlayerPrefs.GetInt("currCoins").ToString();
                //Заработанные монеты в конце уровня
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + PlayerPrefs.GetInt("currCoins"));
                PlayerPrefs.Save();
                first = true;
            }
            else
           if (PlayerPrefs.GetInt("currLevel") == 1 || PlayerPrefs.GetInt("currLevel") == 7 || PlayerPrefs.GetInt("currLevel") == 14)
            {
                if (lang == "ru")
                    coins.text = "Заработано:" + PlayerPrefs.GetInt("currCoins").ToString();
                else coins.text = "Earned:" + PlayerPrefs.GetInt("currCoins").ToString();
                //Заработанные монеты в конце уровня
                PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + PlayerPrefs.GetInt("currCoins"));
                PlayerPrefs.Save();
            }
            else
            {
                if (lang == "ru")
                    coins.text = "Заработано:" + PlayerPrefs.GetInt("currCoins").ToString();
                else coins.text = "Earned:" + PlayerPrefs.GetInt("currCoins").ToString();
                //Заработанные монеты в конце уровня
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + PlayerPrefs.GetInt("currCoins"));
                PlayerPrefs.Save();
            }
        }
        else
        {
            PlayerPrefs.SetInt("loseCount", PlayerPrefs.GetInt("loseCount") + 1);
            if (PlayerPrefs.GetInt("loseCount") == 3)
                if (Advertisement.IsReady())
                {
                    PlayerPrefs.SetInt("loseCount", 0);
                    Advertisement.Show("video");
                }
            buttonLose.SetActive(true);
            buttonWin.SetActive(false);
            if (lang == "ru")
                coins.text = "Вы ничего не заработали";
            else coins.text = "You didn't earn anything";
        }
        if (lang == "ru")
            speed.text = "Символов в минуту:" + Math.Round(PlayerPrefs.GetFloat("TypeSpeed"),2).ToString();
        else speed.text = "Characters per minute:" + Math.Round(PlayerPrefs.GetFloat("TypeSpeed"), 2).ToString();
    }

    public void ButtonVideoAdvertisingX2() //Метод увеличения заработанных монет на уровне в два раза
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");//Вид рекламы который можно пропустить
            if (!first)
            {
                if (PlayerPrefs.GetInt("currLevel") == 1 || PlayerPrefs.GetInt("currLevel") == 7 || PlayerPrefs.GetInt("currLevel") == 14)
                {
                    PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + (PlayerPrefs.GetInt("currCoins")));         //Полученные доллары на уровне увеличиваем в два раза
                }
                else
                {
                    PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + (PlayerPrefs.GetInt("currCoins")));         //Полученные монеты на уровне увеличиваем в два раза
                }
            }
            else
            {
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + (PlayerPrefs.GetInt("currCoins")));         //Полученные монеты на уровне увеличиваем в два раза
            }
        }
        BtnVideoX2.SetActive(false);
        //BtnVideoX2.GetComponentInChildren<Text>().text = "😅";
    }


}
