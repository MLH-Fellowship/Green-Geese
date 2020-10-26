using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;

    public int numOfPlatforms = 100;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = .8f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
