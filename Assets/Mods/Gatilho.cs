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


     
}

}
