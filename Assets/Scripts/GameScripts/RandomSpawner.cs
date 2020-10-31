using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public float spawnTimer = 5f;

    private int randomSpawnLocations;
    private int randomItemSpawn;

    [Header("Spawn Points")]
    //Array of Spawn Locations
    [SerializeField] private Transform[] spawnLocations;


    [Header("GameObjects to Spawn")]
    [SerializeField] private GameObject[] trickOrCandy;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RandomLocationSpawns();
        
    }


    void RandomLocationSpawns()
    {
        spawnTimer -= Time.deltaTime;//Spawn timer before an object is spawned

        randomSpawnLocations = Random.Range(0, spawnLocations.Length);//gets a random spawn point to spawn candy
        randomItemSpawn = Random.Range(0, trickOrCandy.Length);

        //5 second timer before random location is chosen
        if (spawnTimer <= 0)
        {
            Debug.Log(spawnLocations[randomSpawnLocations].position);
            Debug.Log(trickOrCandy[randomItemSpawn]);
            Instantiate(trickOrCandy[randomItemSpawn], spawnLocations[randomSpawnLocations].position, Quaternion.identity);
      
            spawnTimer = 5f;
        }
    }

}
