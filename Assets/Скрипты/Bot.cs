using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bot : MonoBehaviour
{
    public Animator anim;
    public int botDificulty;
    private bool moving = false;
    private int countLetters;
    private float position = 0;
    private Vector3 moveTo;
    public GameObject platform;
    public GameObject botPlatformEnd;
    private float time = 0;
    public float botSpeed;
    private float currLetter = 0;
    void Start()
    {
        countLetters = string.Join(" ", FindObjectOfType<CreatePlatformWithLetters>().letters[PlayerPrefs.GetInt("currLevel")]).Length;
        moveTo = this.transform.position;
        position = botPlatformEnd.transform.position.z - 0.2f;
        switch (botDificulty)
        {
            case (1):
                {
                    botSpeed = Random.Range(0.5f,1f);
                    break; }
            case (2):
                {
                    botSpeed = Random.Range(0.4f, 0.6f);
                    break; }
            case (3):
                {
                    botSpeed = Random.Range(0.35f, 0.55f);
                    break; }
            case (4):
                {
                    botSpeed = Random.Range(0.3f, 0.5f);
                    break;
                }
            case (5):
                {
                    botSpeed = Random.Range(0.25f, 0.45f);
                    break;
                }
            default:
                break;
        }
    }

    void Update()
    {
        if(FindObjectOfType<Moving>().start) time += Time.deltaTime;
        if (currLetter < countLetters)
        {
            if (time > botSpeed)
            {
                currLetter++;
                Instantiate(platform, new Vector3(botPlatformEnd.transform.position.x, botPlatformEnd.transform.position.y, position), Quaternion.Euler(0, 0, 0));
                moveTo = new Vector3(botPlatformEnd.transform.position.x, this.transform.position.y, position);
                position -= .5f;
                time = 0;
            }
        }else
        {
            PlayerPrefs.SetInt("Win", 0);
            SceneManager.LoadScene("MenuEndLevel");
        }
        Move(moveTo);
        AnimateBot();
    }
    void Move(Vector3 toPosition)
    {
        if (Vector3.Distance(this.transform.position, toPosition) > 0.1) moving = true; else moving = false;
        transform.position = Vector3.Lerp(this.transform.position, toPosition, 0.1f);
    }
    void AnimateBot()
    {
        if (moving) anim.SetBool("run", true);
        else anim.SetBool("run", false);
    }
}
