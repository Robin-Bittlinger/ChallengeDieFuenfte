using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject ThingToSpawn;
    [Range(0f,6f)]
    public float radius = 3f;
    public float spawnRate = 1f;
    private Vector3 location = new Vector3(1,1,1);
 

    void Start()
    {
        InvokeRepeating("SpawnCube", 1.0f, spawnRate); 
    }

    Vector3 randomLocation()
    {
        Vector3 randomLocation = new Vector3(Random.Range(-radius, radius), Random.Range(-radius, radius), Random.Range(-radius, radius)); 

        return randomLocation;
    }

    void SpawnCube()
    {
        var clone = Instantiate(ThingToSpawn, randomLocation(), ThingToSpawn.transform.rotation);
        SetDeadline(clone);
    }

    void SetDeadline(GameObject clone)
    {
        var cube = clone.GetComponent<Cube>();
        cube.deadline = Random.Range(Cube.minLive, Cube.maxLive);
    }


}
