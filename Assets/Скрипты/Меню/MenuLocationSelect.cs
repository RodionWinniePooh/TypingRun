using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MenuLocationSelect : MonoBehaviour
{
    public GameObject[] locationPrefab;
    public Material day;
    public Material night;
    public Light sun;









    void Start()
    {

        


        int location = PlayerPrefs.GetInt("LocationNum");
        for (int i = 0; i < locationPrefab.Length; i++)
        {
            if (i == location)
            {
                if (location == 2)
                {
                    locationPrefab[i].SetActive(true);
                    FindObjectOfType<Skybox>().material = night;
                    sun.intensity = 0.5f;
                }
                else
                {
                    locationPrefab[i].SetActive(true);
                    FindObjectOfType<Skybox>().material = day;
                    sun.intensity = 1f;
                }
            }
            else locationPrefab[i].SetActive(false);
        }
        if(location>=locationPrefab.Length)
        {
            locationPrefab[2].SetActive(true);
            FindObjectOfType<Skybox>().material = night;
            sun.intensity = 0.5f;
        }


        
    }







}
