using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [Header("Seconds Till Object Spawns")]
    public float spawnTime;//starting time till object is spawned
    private float spawnCountDown;

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
        spawnCountDown = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        RandomLocationSpawns();
        

        //Error Checks
        if(trickOrCandy == null)
        {
            Debug.LogError("Item Prefabs need to be added to the Array");
        }
    }


    void RandomLocationSpawns()
    {
        
        spawnCountDown -= Time.deltaTime;//Spawn timer before an object is spawned

        randomSpawnLocations = Random.Range(0, spawnLocations.Length);//gets a random spawn point to spawn candy
        randomItemSpawn = Random.Range(0, trickOrCandy.Length);//gets a random item from array of objects to spawn

        //5 second timer before random location is chosen
        if (spawnCountDown <= 0)
        {
            Debug.Log(spawnLocations[randomSpawnLocations].position);
            Debug.Log(trickOrCandy[randomItemSpawn]);
            Instantiate(trickOrCandy[randomItemSpawn], spawnLocations[randomSpawnLocations].position, Quaternion.identity);
      
            spawnCountDown = spawnTime;
        }
    }

}
