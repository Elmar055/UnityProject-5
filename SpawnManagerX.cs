using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    // ball prefabs array
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22; // left limit for range
    private float spawnLimitXRight = 7; // right limit for range
    private float spawnPosY = 30; // y position for spawnpos


    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        // code for random index(random balls)
        int ballNumber = Random.Range(0,ballPrefabs.Length);
        // clone and send a random ball a random position
        Instantiate(ballPrefabs[ballNumber], spawnPos, ballPrefabs[ballNumber].transform.rotation);

        // execute this method 3-5 second interval
        Invoke("SpawnRandomBall", Random.Range(3f,5f));
    }

}
