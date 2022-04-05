using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPet : MonoBehaviour
{
    
 public GameObject pickupEffect; // Efeito das particulas
 public GameObject meshObject; // Rotação do objeto
   void Update()
    {
        meshObject.transform.Rotate(0,0,0);
        meshObject.transform.Translate(0, Mathf.Sin(Time.time*8)*0.20f, 0);
    }
 void OnTriggerEnter (Collider other)
 {

     if (other.CompareTag("Player"))
     {
         Pickup();
     }
 }

 void Pickup()
 {
     Instantiate(pickupEffect, transform.position, transform.rotation);

     Destroy(gameObject);
 }

}
