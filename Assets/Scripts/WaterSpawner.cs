using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : MonoBehaviour
{
    public GameObject waterParticlePrefab;
    public Transform spawnLocation;
    public bool tapOn;
    public float spawntime = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        tapOn = false;
    }

    

    public void toggleTap()
    {
        tapOn = !tapOn;

        if (tapOn)
        {
            InvokeRepeating("SpawnParticle", 0f, spawntime);
        }
        else
        {
            CancelInvoke("SpawnParticle");
        }
    }

    public void SpawnParticle()
    {
        Instantiate(waterParticlePrefab, spawnLocation);
    }
}
