using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Advertisements;
using System;

public class MainMenu : MonoBehaviour
{

    public Text        textCoin;
    public Text        textDollar;
    public Text        currlevel;
    public AudioSource audioSource;
    public AudioMixer  mixerMusic;
    public AudioMixer  mixerSound;






    void Start()
    {
        //EraseAll();
        TextCoin();

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









        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3860681", false);
        }
        currlevel.text += " " + PlayerPrefs.GetInt("levelNum").ToString();


    }

    private void Update()
    {
        TextCoin();
    }
    public void TextCoin()
    {
        textCoin.text = PlayerPrefs.GetInt("Coins").ToString();
        textDollar.text = PlayerPrefs.GetInt("Dollar").ToString();
    }

    public void QuitGame() //Метод отвечащий за выход из игры (расположен в объекте MainMenu)
    {
        Debug.Log("Выход из игры");
        Invoke("QuitInvoke", 0.5f);
    }

    void QuitInvoke()
    {
        Application.Quit();
    }



    public void GoToShop() //Метод отвечающий за переход со сцены Menu на сцену Shop
    {
        Invoke("GoToShopInvoke", 0.5f);
    }

    void GoToShopInvoke()
    {
        SceneManager.LoadScene("Shop");
    }



    public void GoToPerson()
    {
        SceneManager.LoadScene("Person");
    }

    
}
