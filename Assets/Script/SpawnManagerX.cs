using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Extra Credit :)
public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] NPCPrefabs;

    private float spawnLimitXLeft = 7;
    private float spawnLimitXRight = -7;
    private float spawnPosY = 4;

    private float startDelay = 1.0f;
    private float spawnInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomNPC", startDelay, spawnInterval);
    }

    // Spawn random NPC at random x position at top of play area
    void SpawnRandomNPC ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate NPC at random spawn location
        Instantiate(NPCPrefabs[0], spawnPos, NPCPrefabs[0].transform.rotation);
    }

}
