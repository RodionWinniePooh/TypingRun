using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BuyPlayerPerson : MonoBehaviour
{
    private buyBtnPerson[] buys;

    void Start()
    {
        buys = FindObjectsOfType<buyBtnPerson>();

        foreach (var item in buys)
        {
            if (PlayerPrefs.GetInt("Player" + item.index) == 1) //Если скин куплен показываем
            {
                item.GetComponent<Button>().interactable = true;
            }

            if (PlayerPrefs.GetInt("Player" + item.index) == 0) //Если скин не куплен убираем его
            {
                item.GetComponent<Button>().onClick.RemoveAllListeners();
                Destroy(item.gameObject);
            }
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
