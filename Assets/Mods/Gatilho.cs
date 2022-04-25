using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gatilho : MonoBehaviour
{

public GameFlowManager gameFlowManager;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
 {
     if (other.gameObject.CompareTag("Player2")){

         gameFlowManager.EndGame1(true);
        

        }
     
     if (other.gameObject.CompareTag("Player1")){

         gameFlowManager.EndGame(true);
         

        }
       // if (other.CompareTag("Player"))
       // {
          //  StartCoroutine(Pickup(other));
      //  }




}
   // IEnumerator Pickup(Collider player)
   // {
       // yield return new WaitForSeconds(6f);

        // // Podemos utilizar a função abaixo para o efeito instanciar no game object escolhido ~ no caso, o carro.
        // GameObject clone = (GameObject)Instantiate(pickupEffect, transform.position, transform.rotation);
        //
        // // para a hierarquia
        // clone.transform.parent = player.transform;

        //Efeito
        //player.transform.localScale = new Vector3(100, 100, 100);


   // }

}
