using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class NextLvl : MonoBehaviour
{
    public void Play()
    {
        Debug.Log(PlayerPrefs.GetInt("currLevel"));
        int GameNum = PlayerPrefs.GetInt("LocationNum");
        int currLevel = PlayerPrefs.GetInt("currLevel");
        if (currLevel==20)
        {
            GameNum += 1;
            PlayerPrefs.SetInt("LocationNum", GameNum);
            PlayerPrefs.SetInt("currLevel", 0);

            PlayerPrefs.Save();
            switch (GameNum)
            {
                case (1):
                    {
                        SceneManager.LoadScene("GameBonus");
                        break;
                    }
                case (2):
                    {
                        SceneManager.LoadScene("Game1Bonus");
                        break;
                    }
                case (3):
                    {
                        SceneManager.LoadScene("Game2Bonus");
                        break;
                    }
                default:
                    break;
            }
        }
        else if(currLevel==6 || currLevel == 13)
        {
            switch (GameNum)
            {
                case (0):
                    {
                        SceneManager.LoadScene("GameBonus");
                        break;
                    }
                case (1):
                    {
                        SceneManager.LoadScene("Game1Bonus");
                        break;
                    }
                case (2):
                    {
                        SceneManager.LoadScene("Game2Bonus");
                        break;
                    }
                default:
                    break;
            }
        } else
            switch (GameNum)
            {
                case (0):
                    {
                        SceneManager.LoadScene("Game");
                        break;
                    }
                case (1):
                    {
                        SceneManager.LoadScene("Game1");
                        break;
                    }
                case (2):
                    {
                        SceneManager.LoadScene("Game2");
                        break;
                    }
                default:
                    {
                        SceneManager.LoadScene("Menu");
                        break;
                    }

            }
    }

    public void PlaySceneEndLevel() //Метод с задержкой что бы музыка успевала доиграть до конца
    {
        //Invoke("PlayInvoke", 3f);
        PlayInvoke();
    }

    void PlayInvoke()
    {
        int GameNum = PlayerPrefs.GetInt("LocationNum");
        int currLevel = PlayerPrefs.GetInt("currLevel");
        if (currLevel == 20)
        {
            GameNum += 1;
            PlayerPrefs.SetInt("LocationNum", GameNum);
            PlayerPrefs.SetInt("currLevel", 0);

            PlayerPrefs.Save();
            switch (GameNum)
            {
                case (1):
                    {
                        SceneManager.LoadScene("GameBonus");
                        break;
                    }
                case (2):
                    {
                        SceneManager.LoadScene("Game1Bonus");
                        break;
                    }
                case (3):
                    {
                        SceneManager.LoadScene("Game2Bonus");
                        break;
                    }
                default:
                    break;
            }
        }
        else if (currLevel == 6 || currLevel == 13)
        {
            switch (GameNum)
            {
                case (0):
                    {
                        SceneManager.LoadScene("GameBonus");
                        break;
                    }
                case (1):
                    {
                        SceneManager.LoadScene("Game1Bonus");
                        break;
                    }
                case (2):
                    {
                        SceneManager.LoadScene("Game2Bonus");
                        break;
                    }
                default:
                    break;
            }
        }
        else
            switch (GameNum)
            {
                case (0):
                    {
                        SceneManager.LoadScene("Game");
                        break;
                    }
                case (1):
                    {
                        SceneManager.LoadScene("Game1");
                        break;
                    }
                case (2):
                    {
                        SceneManager.LoadScene("Game2");
                        break;
                    }
                default:
                    {
                        SceneManager.LoadScene("Menu");
                        break;
                    }

            }
    }


    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }


}
