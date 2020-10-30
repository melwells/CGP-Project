using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour
{
    public GameObject[] spawnPickup;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnPickup[Random.Range(0, spawnPickup.Length)], this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
