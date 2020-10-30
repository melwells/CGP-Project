using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFireball : MonoBehaviour
{
    //Destroying fireball after a certain amount of time. This
    //is only functional for SHMUP, not if we can get bounce mechanic
    //to work
  public float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy (gameObject, lifetime);
    }
}