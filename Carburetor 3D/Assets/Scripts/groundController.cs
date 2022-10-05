using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundController : MonoBehaviour
{
    public GameObject ground;
    public Transform spawnPoint;
    public Transform player;

    public Vector3 offSet;

    public float timeBetweenWaves = 1f;
    private float timeToSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            Instantiate(ground, spawnPoint.position, Quaternion.identity);
            timeToSpawn = Time.time + timeBetweenWaves;
        }
        transform.position = player.position + offSet;
    }
}
