using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [Header("Game Controller")]
    [SerializeField] private GameObject gameController;
    [SerializeField] private GameController controller;

    [Header("Seconds Till Object Spawns")]
    public float spawnTime;//starting time till object is spawned
    private float spawnCountDown;
    private float secondSpawnCountDown;

    private int randomSpawnLocations;
    private int randomItemSpawn;

    [Header("Spawn Points")]
    //Array of Spawn Locations
    [SerializeField] private Transform[] spawnLocations;


    [Header("GameObjects to Spawn")]
    [SerializeField] private GameObject[] trickOrCandy;


    public int spawnMultiplier;//Increases number of spawns every multiple of 5
    // Start is called before the first frame update
    void Start()
    {
        spawnCountDown = spawnTime;

        controller = gameController.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.miniGameStarted)
        {
            RandomLocationSpawns();


            //Adds another wave of random spawns based on the level youre on

            //Level 2
            if(controller.level >= 2)
            {
                RandomLocationSpawns();
            }

            //Level 3
            if(controller.level >= 3)
            {
                RandomLocationSpawns();
            }

            //Level 4
            if(controller.level >= 4)
            {
                RandomLocationSpawns();
            }

        }
        

        //Error Checks
        if (trickOrCandy == null)
        {
            Debug.LogError("Item Prefabs need to be added to the Array");
        }
    }


    void RandomLocationSpawns()
    {
        
        spawnCountDown -= Time.deltaTime;//Spawn timer before an object is spawned

        randomSpawnLocations = Random.Range(0, spawnLocations.Length);//gets a random spawn point to spawn candy

        randomItemSpawn = Random.Range(0, trickOrCandy.Length);//gets a random item from array of objects to spawn

        //timer before random location is chosen
        if (spawnCountDown <= 0)
        {
            Instantiate(trickOrCandy[randomItemSpawn], spawnLocations[randomSpawnLocations].position, Quaternion.identity);

            spawnCountDown = spawnTime;
        }
    }

}
