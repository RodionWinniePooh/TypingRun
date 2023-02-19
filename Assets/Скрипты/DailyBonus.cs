using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class DailyBonus : MonoBehaviour
{

    public GameObject[] daysPanel;

    public GameObject mainCanvas;
    public GameObject dailyCanvas;
    public AudioMixer mixerMusic;
    public AudioMixer mixerSound;

    public Button claimButton;

    private int currDay = 0;
    private bool claimed = false;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("FirstStart")==0)
        {
            EraseAll();
        }
        if (PlayerPrefs.GetInt("MUTED Music") == 1)
        {
            mixerMusic.SetFloat("volume", 0);
        }
        if (PlayerPrefs.GetInt("MUTED Music") == 0)
        {
            mixerMusic.SetFloat("volume", -80);
        }


        if (PlayerPrefs.GetInt("MUTED Sound") == 1)
        {
            mixerSound.SetFloat("volumeSound", 0);
        }
        if (PlayerPrefs.GetInt("MUTED Sound") == 0)
        {
            mixerSound.SetFloat("volumeSound", -80);
        }
        Debug.Log(PlayerPrefs.GetInt("RewardedYear"));
        Debug.Log(PlayerPrefs.GetInt("RewardedMonth"));
        Debug.Log(PlayerPrefs.GetInt("RewardedDay"));
        Debug.Log(PlayerPrefs.GetInt("RewardedHour"));
        Debug.Log(PlayerPrefs.GetInt("RewardedMinute"));
        Debug.Log(PlayerPrefs.GetInt("RewardedSecond"));
        DateTime RewardedDT = new DateTime(PlayerPrefs.GetInt("RewardedYear", DateTime.Now.Year), PlayerPrefs.GetInt("RewardedMonth", DateTime.Now.Month), PlayerPrefs.GetInt("RewardedDay", DateTime.Now.Day),
                                           PlayerPrefs.GetInt("RewardedHour", DateTime.Now.Hour), PlayerPrefs.GetInt("RewardedMinute", DateTime.Now.Minute), PlayerPrefs.GetInt("RewardedSecond", DateTime.Now.Second));
        Debug.Log(RewardedDT);
        currDay = PlayerPrefs.GetInt("currDay");
        if (RewardedDT <= DateTime.Now && (DateTime.Now - RewardedDT).Days >= 0)
        {
            panelsCreate();
        }
        else
        {
            mainCanvas.gameObject.SetActive(true);
            dailyCanvas.gameObject.SetActive(false);
        }
    }

    public void claimReward() 
    {
        DateTime RewardedDT = DateTime.Now.AddDays(1);
        PlayerPrefs.SetInt("RewardedYear", RewardedDT.Year);
        PlayerPrefs.SetInt("RewardedMonth", RewardedDT.Month);
        PlayerPrefs.SetInt("RewardedDay", RewardedDT.Day);
        PlayerPrefs.SetInt("RewardedHour", RewardedDT.Hour);
        PlayerPrefs.SetInt("RewardedMinute", RewardedDT.Minute);
        PlayerPrefs.SetInt("RewardedSecond", RewardedDT.Second);
        daysPanel[currDay].GetComponent<Image>().color = Color.red; //собрали ежедневный бонус
        if (currDay != 4)
        {
            if (!daysPanel[currDay].GetComponent<DailyBonusCount>().dolar)
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + daysPanel[currDay].GetComponent<DailyBonusCount>().value);
            else PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") + daysPanel[currDay].GetComponent<DailyBonusCount>().value);
        }
        else PlayerPrefs.SetInt("Player4", 1);
        if(currDay+1<=4)
        PlayerPrefs.SetInt("currDay", currDay + 1);
        else PlayerPrefs.SetInt("currDay", 0);
        claimed = true;
        claimButton.enabled = false;
    }

    public void closeDailyBonusPage() //По нажатию на значок выхода
    {
        if(!claimed)
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + daysPanel[currDay].GetComponent<DailyBonusCount>().value);
        mainCanvas.SetActive(true);
        dailyCanvas.SetActive(false);
    }
    private void panelsCreate()
    {
        currDay = PlayerPrefs.GetInt("currDay");
        //for (int i = 0; i < daysPanel.Length; i++)
        //{
        //    daysPanel[i].GetComponent<Image>().color = Color.grey;//Все остальные
        //}
        for (int i = 0; i < currDay; i++)
        {
            daysPanel[i].GetComponent<Image>().color = Color.red; //Собранные
        }
        daysPanel[currDay].GetComponent<Image>().color = Color.green; //Желтый текущий день
    }
    public void EraseAll()
    {
        PlayerPrefs.SetInt("FirstTime", 0);
        PlayerPrefs.SetInt("loseCount", 0);
        PlayerPrefs.SetInt("winCount", 0);
        PlayerPrefs.SetInt("FirstStart", 1);
        PlayerPrefs.SetInt("TypeCount", 0);
        PlayerPrefs.SetInt("TypeSpeed", 0);
        PlayerPrefs.SetInt("MUTED Music", 1);
        PlayerPrefs.SetInt("MUTED Sound", 1);
        PlayerPrefs.SetString("_language", "ru");
        PlayerPrefs.SetInt("RewardedYear", DateTime.Now.Year - 1);
        PlayerPrefs.SetInt("RewardedMonth", DateTime.Now.Month - 1);
        PlayerPrefs.SetInt("RewardedDay", DateTime.Now.Day - 1);
        PlayerPrefs.SetInt("RewardedHour", DateTime.Now.Hour - 1);
        PlayerPrefs.SetInt("RewardedMinute", DateTime.Now.Minute - 1);
        PlayerPrefs.SetInt("RewardedSecond", DateTime.Now.Second - 1);
        PlayerPrefs.SetInt("currDay", 0);
        PlayerPrefs.SetInt("LocationNum", 0);
        PlayerPrefs.SetInt("currLevel", 0);
        PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.SetInt("Dollar", 0);
        PlayerPrefs.SetInt("levelNum", 1);
        PlayerPrefs.SetInt("FirstStart", 1);
        PlayerPrefs.SetInt("currSkin", 0);
        PlayerPrefs.SetInt("Player0", 1);
        PlayerPrefs.SetInt("Player1", 0);
        PlayerPrefs.SetInt("Player2", 0);
        PlayerPrefs.SetInt("Player3", 0);
        PlayerPrefs.SetInt("Player4", 0);
        PlayerPrefs.SetInt("Player5", 0);
        PlayerPrefs.SetInt("Player6", 0);
        PlayerPrefs.SetInt("Player7", 0);
        PlayerPrefs.SetInt("Player8", 0);
        PlayerPrefs.SetInt("Player9", 0);
        PlayerPrefs.SetInt("Player10", 0);
        PlayerPrefs.SetInt("Player11", 0);
        PlayerPrefs.SetInt("Player12", 0);
        PlayerPrefs.SetInt("Player13", 0);
        PlayerPrefs.SetInt("Player14", 0);
        PlayerPrefs.SetInt("Player15", 0);
        PlayerPrefs.SetInt("Player16", 0);
        PlayerPrefs.SetInt("Player17", 0);
        PlayerPrefs.SetInt("PlayerAccess0", 0);
        PlayerPrefs.SetInt("PlayerAccess1", 0);
        PlayerPrefs.SetInt("PlayerAccess2", 0);
        PlayerPrefs.SetInt("PlayerAccess3", 0);
        PlayerPrefs.SetInt("PlayerAccess4", 0);
        PlayerPrefs.SetInt("PlayerAccess5", 0);
        PlayerPrefs.SetInt("PlayerAccess6", 0);
        PlayerPrefs.SetInt("PlayerAccess7", 0);
        PlayerPrefs.SetInt("PlayerAccess8", 0);
        PlayerPrefs.SetInt("PlayerAccess9", 0);
        PlayerPrefs.SetInt("PlayerAccess10", 0);
        PlayerPrefs.SetInt("PlayerAccess11", 0);
        PlayerPrefs.SetInt("PlayerAccess12", 0);
        PlayerPrefs.SetInt("PlayerAccess13", 0);
        PlayerPrefs.SetInt("PlayerAccess14", 0);
        PlayerPrefs.SetInt("PlayerAccess15", 0);
        PlayerPrefs.SetInt("PlayerAccess16", 0);
        PlayerPrefs.SetInt("PlayerAccess17", 0);
        PlayerPrefs.SetInt("PlayerAccess18", 0);
        PlayerPrefs.SetInt("PlayerAccess19", 0);
        PlayerPrefs.SetInt("PlayerAccess20", 0);
        PlayerPrefs.SetInt("PlayerAccess21", 0);
        PlayerPrefs.SetInt("PlayerAccess22", 0);
        PlayerPrefs.SetInt("PlayerAccess23", 0);
        PlayerPrefs.SetInt("PlayerAccess24", 0);
        PlayerPrefs.SetInt("PlayerAccess25", 0);
        PlayerPrefs.SetInt("PlayerAccess26", 0);
        PlayerPrefs.SetInt("ButtonItem1", 0);
        PlayerPrefs.SetInt("ButtonItem2", 0);
        PlayerPrefs.SetInt("ButtonItem3", 0);
        PlayerPrefs.SetInt("PlayerAccess", -1);
    }
}
