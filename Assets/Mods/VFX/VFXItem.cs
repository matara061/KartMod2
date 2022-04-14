using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VFXItem : MonoBehaviour
{
    public GameObject pickupEffect;
    public AudioSource Sound;
    float timetoDestroy = 5f;
    

    void OnTriggerEnter (Collider other)
 {

     if (other.CompareTag("Player"))
     {
         Pickup(other);
         
        }
 }
 void Pickup(Collider player)
 {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        



    }


}
