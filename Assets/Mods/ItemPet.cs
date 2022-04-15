using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPet : MonoBehaviour
{

 float timetoDestroy = 3f;
 public GameObject pickupEffect; // Efeito das particulas
 public GameObject meshObject; // Rotação do objeto
 


    void Update()
    {
        meshObject.transform.Rotate(0,0,0);
        meshObject.transform.Translate(0, 0, Mathf.Sin(Time.time * 8) * 0.20f);
    }
 void OnTriggerEnter (Collider other)
 {

     if (other.CompareTag("Player"))
     {
         StartCoroutine(Pickup(other));
         Destroy(gameObject, timetoDestroy);
     }
        FindObjectOfType<AudioManager2>().Play("Coracao");
    }

    // Enumerator é para a função couratine, que faz com que o sistema tenha a função de espera e pausa.
    IEnumerator Pickup(Collider player)
    {
        // Podemos utilizar a função abaixo para o efeito instanciar no game object escolhido ~ no caso, o carro.
        GameObject clone = (GameObject)Instantiate(pickupEffect, transform.position, transform.rotation);

        // para a hierarquia
        clone.transform.parent = player.transform;

        //Efeito
        player.transform.Translate(0, 20, 0);

        

        yield return new WaitForSeconds(3f);

        //Destruir o clone
        Destroy(clone.gameObject, timetoDestroy);

    }

}