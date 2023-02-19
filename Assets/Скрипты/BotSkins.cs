using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotSkins : MonoBehaviour
{

    public GameObject[] bodys;
    public GameObject[] heads;
    void Start()
    {
        int body = Random.Range(0, bodys.Length);
        bodys[body].gameObject.SetActive(true);
        int head = Random.Range(0, heads.Length);
        heads[head].gameObject.SetActive(true);
    }
}
