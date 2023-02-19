using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string lang = PlayerPrefs.GetString("_language", "ru");
        if (PlayerPrefs.GetInt("TypeCount")==0)
        {
            if(lang=="ru")
            this.GetComponent<Text>().text = "Мы не знаем вашу скорость печати";
            else this.GetComponent<Text>().text = "We don't know your print speed";
        }
        else
        {
            if (lang == "ru")
                this.GetComponent<Text>().text = "Ваша средняя скорость печати:"+Math.Round(PlayerPrefs.GetFloat("TypeSpeed"),2)+" символа в минуту!";
            else this.GetComponent<Text>().text = "Your average print speed:" + Math.Round(PlayerPrefs.GetFloat("TypeSpeed"), 2) + " characters per minute!";
        }
    }

}
