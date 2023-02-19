using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsText : MonoBehaviour
{
    // Start is called before the first frame update
    public Text allCoinsUIText;
    public Text allDollarsUIText;

    void Update()
    {
        UpdateAllCoinsUIText();
    }
    public void UpdateAllCoinsUIText()
    {
            allCoinsUIText.text = PlayerPrefs.GetInt("Coins").ToString();
            allDollarsUIText.text = PlayerPrefs.GetInt("Dollar").ToString();
    }
}
