using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MenuTraining : MonoBehaviour
{



    //Объекты для CanvasTraining
    public Canvas CanvasTraining;
    public GameObject BackTraining;
    public VideoClip[] Video;
    public GameObject VideoTraining;
    public Canvas CanvasDailyBonus;
    public Canvas CanvasMenu;
    int count = 0;
    void Start()
    {
        if (PlayerPrefs.GetInt("PlayerTraining") == 1) //Если обучение пройдено
        {
            CanvasTraining.gameObject.SetActive(false); //отключаем canvas обучение
            BackTraining.SetActive(false); //отключаем задний фон
            VideoTraining.SetActive(false);



        }

        if (PlayerPrefs.GetInt("PlayerTraining") == 0) //Если обучение не пройдено
        {
            CanvasMenu.gameObject.SetActive(false);
            CanvasDailyBonus.gameObject.SetActive(false); //включаю бонусы
            //убираем все видео
            //задний план
            //кнопки даллее и пропустить а лучше убрать только canvas

            //сделать массив из видео идти по циклу и если доходим до конца то обучение пройдено
            CanvasTraining.gameObject.SetActive(true);

        }
    }



    public void SkipTraining()
    {

        PlayerPrefs.SetInt("PlayerTraining", 1); //Ставим значение что обучение было якобы пройдено

        CanvasTraining.gameObject.SetActive(false);
        VideoTraining.SetActive(false);
        BackTraining.SetActive(false); //отключаем задний фон
        CanvasDailyBonus.gameObject.SetActive(true); //включаю бонусы


    }

    public void ContinueTrainingVideo()
    {


        for (int i = 0; i < Video.Length; i++)
        {
            if (count == 2)
            {
                SkipTraining();
            }
            VideoTraining.GetComponent<VideoPlayer>().clip = Video[count];
        }
        count++;
    }
}
