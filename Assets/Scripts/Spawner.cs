using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //object that attaches to the script for spawning object
    [Header("ChallengeObj Game Object")]
    public GameObject challengeObject;
    //Spawning delay time
    [Header("Default spawn delay time")]
    public float spawnDelay = 1f;
    //spawning time for each object appearing
    [Header("Default spawn time")]
    public float spawnTime = 2f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(6.7f, -4.6f, 0.16f);
    }

    void InstantiateObjects()
    {
        Instantiate(challengeObject, transform.position, transform.rotation);
    }

}
