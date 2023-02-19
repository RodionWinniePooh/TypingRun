using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buyBtn : MonoBehaviour
{
    public int Price;
    public GameObject modelSkin;
    [HideInInspector]
    public bool isDown=false;
    public int index;
    public Button BuyButton;
    public Image waluteImg;
    public Sprite dollarImg;
    public Sprite coinImg;
    public bool isDollar;
    public bool isAccessorie;



    public void Pressed()
    {
        
        buyBtn[] buttons = FindObjectsOfType<buyBtn>();
        foreach (var item in buttons)
        {
            item.isDown = false;
        }
        isDown = true;
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].index!=index) //Если кнопка не выбрана
            {
                buttons[i].GetComponent<Image>().color = Color.white;
                buttons[i].modelSkin.SetActive(false);

            }
            else
            {
                for (int k = 0; k < buttons.Length; k++)
                {
                    if (k!=i)
                    {
                        this.GetComponent<Image>().color = Color.yellow;
                        modelSkin.SetActive(true);
                    }                  
                }
                

                if (PlayerPrefs.GetInt("Player"+index)==0)
                {
                    //Выводим значение денег в кнопку
                    waluteImg.enabled = true;
                    if(isDollar || isAccessorie)
                    waluteImg.sprite = dollarImg;
                    else waluteImg.sprite = coinImg;
                    BuyButton.GetComponentInChildren<Text>().text = Price.ToString(); 
                    BuyButton.interactable = true;
                }
                else BuyButton.GetComponentInChildren<Text>().text = "Куплено";

                if (PlayerPrefs.GetInt("PlayerAccess" + index) == 0)
                {
                    //Выводим значение денег в кнопку
                    BuyButton.GetComponentInChildren<Text>().text = Price.ToString(); 
                    BuyButton.interactable = true;
                }
            }
            
                
        }
    }
}
