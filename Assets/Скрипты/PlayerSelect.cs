using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public GameObject[] playerModels;

    private Cinemachine.CinemachineFreeLook gameCamera;

    private int currPlayer;
    void Start()
    {
        gameCamera = FindObjectOfType<Cinemachine.CinemachineFreeLook>();
        currPlayer = PlayerPrefs.GetInt("currSkin");
        for (int i = 0; i < playerModels.Length; i++)
        {
            if (i != currPlayer) playerModels[i].SetActive(false);
            else
            {
                playerModels[i].SetActive(true);
                if(PlayerPrefs.GetInt("Win")==0)
                {
                    playerModels[i].GetComponent<Animator>().SetBool("Lose", true);
                }
                PlayerPrefs.SetInt("Win", 0);
            }
        }
        if (gameCamera != null)
        {
            gameCamera.Follow = playerModels[currPlayer].transform;
            gameCamera.GetRig(1).LookAt = playerModels[currPlayer].GetComponentInChildren<Head>().transform;
            gameCamera.GetRig(2).LookAt = playerModels[currPlayer].GetComponentInChildren<Bottom>().transform;
        }
    }
}
