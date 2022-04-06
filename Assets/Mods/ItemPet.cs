using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPet : MonoBehaviour
{

 float timetoDestroy = 5f;
 public GameObject pickupEffect; // Efeito das particulas
 public GameObject meshObject; // Rotação do objeto
 Rigidbody player_Rigidbody;


    void Start()
    {
        player_Rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        meshObject.transform.Rotate(0,0,0);
        meshObject.transform.Translate(Mathf.Sin(Time.time * 8) * 0.20f, 0, 0);
    }
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
        player.transform.Translate(5, 20, 0);
        Destroy(gameObject, timetoDestroy);
    }

}