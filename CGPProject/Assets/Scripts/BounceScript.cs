using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
    //Script for player shooting off fireballs.
    public Transform bouncePoint;
    public GameObject fireballPrefab;
    // Update is called once per frame
   /* void Update()
    {
        //if you shoot weapon
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //shmup logic
        Instantiate(fireballPrefab, bouncePoint.position, bouncePoint.rotation);

    } */
}
