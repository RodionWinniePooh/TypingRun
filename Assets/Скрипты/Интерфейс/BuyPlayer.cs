using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BuyPlayer : MonoBehaviour
{
    private int numPlayer;
    private ButtonPlayer[] buysPlayer;
    private ButtonAccsessory[] buysAccessory;

    public void ChangePlayer()
    {
        PlayerPrefs.SetInt("currSkin", numPlayer); //При нажатии запоминает какой скин
        PlayerPrefs.Save();
    }


    void Start()
    {
        buysPlayer = FindObjectsOfType<ButtonPlayer>();
        buysAccessory = FindObjectsOfType<ButtonAccsessory>();
    }
    private void Update()
    {
        foreach (var item in buysPlayer)
        {
            if (PlayerPrefs.GetInt("Player" + item.GetComponent<buyBtn>().index) == 1)
            {
                item.GetComponent<Button>().interactable = false;
            }
        }
        foreach (var item in buysAccessory)
        {
            if (PlayerPrefs.GetInt("PlayerAccess" + item.GetComponent<buyBtn>().index) == 1)
            {
                item.GetComponent<Button>().interactable = false;
            }
        }
    }

    public void Buy()
    {
        int price = Convert.ToInt32(GameObject.FindGameObjectWithTag("BuyButton").GetComponentInChildren<Text>().text);
        if (HasEnoughCoins(price))
        {
            for (int i = 0; i < buysPlayer.Length; i++)
            {
                if (buysPlayer[i].GetComponent<buyBtn>().isDown && !buysPlayer[i].GetComponent<buyBtn>().isDollar && !buysPlayer[i].GetComponent<buyBtn>().isAccessorie)
                {
                    PlayerPrefs.SetInt("Player" + buysPlayer[i].GetComponent<buyBtn>().index, 1);
                    Debug.Log("за монеты");
                    PlayerPrefs.Save();
                    UseCoins(price);
                    break;
                }

            }
        }

        if (HasEnoughDollar(price))
        {
            for (int i = 0; i < buysPlayer.Length; i++)
            {
                if (buysPlayer[i].GetComponent<buyBtn>().isDown && buysPlayer[i].GetComponent<buyBtn>().isDollar)
                {
                    PlayerPrefs.SetInt("Player" + buysPlayer[i].GetComponent<buyBtn>().index, 1);
                    Debug.Log("за доллары");
                    PlayerPrefs.Save();
                    UseDollar(price);
                    break;
                }
            }
        }

        if (HasEnoughDollar(price))
        {
            for (int i = 0; i < buysAccessory.Length; i++)
            {
                if (buysAccessory[i].GetComponent<buyBtn>().isDown && buysAccessory[i].GetComponent<buyBtn>().isAccessorie && buysAccessory[i].GetComponent<buyBtn>().isDollar)
                {
                    PlayerPrefs.SetInt("PlayerAccess" + buysAccessory[i].GetComponent<buyBtn>().index, 1);
                    Debug.Log("акксесуар");
                    PlayerPrefs.Save();
                    UseDollar(price);
                    break;
                }
            }
        }


    }
    public bool HasEnoughCoins(int amount) //Если было достаточно монет
    {
        return (PlayerPrefs.GetInt("Coins") >= amount);
    }

    public bool HasEnoughDollar(int amount) //Если Было достаточно долларов
    {
        return (PlayerPrefs.GetInt("Dollar") >= amount);
    }

    public void UseCoins(int amount) //Отнимание суммы
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - amount);
        GameObject.FindGameObjectWithTag("BuyButton").GetComponent<Button>().interactable = false;
        PlayerPrefs.Save();
    }

    public void UseDollar(int amount) //Отнимание суммы
    {
        PlayerPrefs.SetInt("Dollar", PlayerPrefs.GetInt("Dollar") - amount);
        GameObject.FindGameObjectWithTag("BuyButton").GetComponent<Button>().interactable = false;
        PlayerPrefs.Save();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
