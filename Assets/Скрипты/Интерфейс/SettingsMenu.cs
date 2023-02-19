using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer mixerMusic;
    public AudioMixer mixerSound;

    public Text musicTextChange;
    public Text soundTextChange;


    public bool isMutedMusic; //музыка отключена 
    public int  isValueMutedMusic;

    public bool isMutedSound; //звуки отключена 
    public int  isValueMutedSound;





    void Start()
    {
        if(PlayerPrefs.GetInt("MUTED Music") == 0) //выключена
        {
            isMutedMusic = true;
            isValueMutedMusic = -80;
            musicTextChange.text = "off";
        }
        if (PlayerPrefs.GetInt("MUTED Music") == 1)//включена
        {
            isMutedMusic = false;
            isValueMutedMusic = 0;
            musicTextChange.text = "on";
        }
        mixerMusic.SetFloat("volume", isValueMutedMusic);


        if (PlayerPrefs.GetInt("MUTED Sound") == 0) //выключена
        {
            isMutedSound = true;
            isValueMutedSound = -80;
            soundTextChange.text = "off";
        }
        if (PlayerPrefs.GetInt("MUTED Sound") == 1)//включена
        {
            isMutedSound = false;
            isValueMutedSound = 0;
            soundTextChange.text = "on";
        }
        mixerSound.SetFloat("volumeSound", isValueMutedSound);

        //AudioListener.pause = isMuted;


    }

    public void MusicChange()
    {
        isMutedMusic = !isMutedMusic;
        //AudioListener.pause = isMuted;
        if (isMutedMusic == false)
        {
            isValueMutedMusic = 0;
            mixerMusic.SetFloat("volume", isValueMutedMusic);
            PlayerPrefs.SetInt("MUTED Music", 1);
            musicTextChange.text = "on";
        }
        if (isMutedMusic == true)
        {
            isValueMutedMusic = -80;
            mixerMusic.SetFloat("volume", isValueMutedMusic);
            PlayerPrefs.SetInt("MUTED Music", 0);
            musicTextChange.text = "off";
        }
        PlayerPrefs.Save();
        
    }


    public void SoundChange()
    {
        isMutedSound = !isMutedSound;
        //AudioListener.pause = isMuted;
        if (isMutedSound == false)
        {
            isValueMutedSound = 0;
            mixerSound.SetFloat("volumeSound", isValueMutedSound);
            PlayerPrefs.SetInt("MUTED Sound", 1);
            soundTextChange.text = "on";
        }
        if (isMutedSound == true)
        {
            isValueMutedSound = -80;
            mixerSound.SetFloat("volumeSound", isValueMutedSound);
            PlayerPrefs.SetInt("MUTED Sound", 0);
            soundTextChange.text = "off";
        }
        PlayerPrefs.Save();

    }

    public void EraseAll()
    {
            PlayerPrefs.SetInt("TypeCount", 0);
            PlayerPrefs.SetInt("loseCount", 0);
            PlayerPrefs.SetInt("winCount", 0);
            PlayerPrefs.SetInt("TypeSpeed", 0);
            PlayerPrefs.SetInt("FirstTime", 0);
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
            PlayerPrefs.SetInt("PlayerAccess", -1);
            PlayerPrefs.SetInt("ButtonItem1", 0);
            PlayerPrefs.SetInt("ButtonItem2", 0);
            PlayerPrefs.SetInt("ButtonItem3", 0);
            PlayerPrefs.SetInt("PlayerTraining", 0);
            SceneManager.LoadScene("Menu");
        }

}
