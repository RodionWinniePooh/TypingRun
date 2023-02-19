using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAchievements : MonoBehaviour
{
    public GameObject CanvasPeson;
    public GameObject SkinsPerson;
    public GameObject CanvasAchievements;
    void Start()
    {
        
    }

    public void Achievements()
    {
        CanvasPeson.gameObject.SetActive(false);
        SkinsPerson.gameObject.SetActive(false);
        CanvasAchievements.gameObject.SetActive(true);
    }
}
