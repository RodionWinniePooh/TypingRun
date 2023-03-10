using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject[] locationPrefabs;

    private float currentZ;
    private GameObject player;
    private int currLocation = 0;
    private GameObject currPlatform;
    private GameObject lastPlatform;
    private int currIteration = 0;
    private float firstZ = -4f;
    // Start is called before the first frame update
    void Start()
    {
        currPlatform = GameObject.FindGameObjectWithTag("FirstPlatform");
        lastPlatform = currPlatform;
        player = FindObjectOfType<Moving>().gameObject;
        currentZ = player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        player = FindObjectOfType<Moving>().gameObject;
        platformsSpawn();
    }

    void platformsSpawn()
    {
        if (currentZ+firstZ>player.transform.position.z)
        {
            currIteration++;
            if(currIteration>1)
            {
                Destroy(lastPlatform);
                lastPlatform = currPlatform;
            }
            firstZ = -25f;
            lastPlatform = currPlatform;
            currentZ = player.transform.position.z;
            currLocation = Random.Range(0, locationPrefabs.Length);
            currPlatform = Instantiate(locationPrefabs[currLocation], new Vector3(currPlatform.transform.position.x, currPlatform.transform.position.y, currPlatform.transform.position.z - 25.5f),Quaternion.Euler(0,0,0));
        }
    }






}
