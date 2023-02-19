using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotNIcknames : MonoBehaviour
{

    private TextMesh textMesh;
    public string[] nicks;

    void Start()
    {
        textMesh = GetComponent<TextMesh>();
        int nick = Random.Range(0, nicks.Length);
        textMesh.text = nicks[nick].ToString();
    }


}
