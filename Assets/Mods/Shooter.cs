using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    IInput[] m_Inputs;
    public ItemReceived itemReceived;
    public GameObject target;
    public GameObject target2;
    public ControlCAr car;
    public Rigidbody rb;

    public InputData Input { get; private set; }

//Efeitos
    public GameObject pickupEffect;
    public GameObject pickupEffect1;
    public GameObject pickupEffect2;
    public GameObject pickupEffect3;
    public GameObject pickupEffect4;

    void Start()
    {
        m_Inputs = GetComponents<IInput>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GatherInputs();

        if (Input.Fire)
        {
            GameObject received = itemReceived.GetItem();
            if (received != null)
            {
                if(itemReceived.count == 1) // Capacete
                {
                    Instantiate(received, target2.transform.position, target.transform.rotation);
                }else

                    if(itemReceived.count == 2) // Raio???
                {
                    rb.drag = 1;
                    Instantiate(pickupEffect2, transform.position, transform.rotation);
                    Instantiate(pickupEffect3, transform.position, transform.rotation);

               }
                else if(itemReceived.count == 3)  // foguete
                {
                    rb.AddForce(transform.forward * 1000000);
                    Instantiate(pickupEffect, transform.position, transform.rotation); //~ Duvida professor
                    Instantiate(pickupEffect1, transform.position, transform.rotation);
                }else 
                    if(itemReceived.count == 4 || itemReceived.count == 0) // coração e BolaEspinho
            Instantiate(received, target.transform.position, target.transform.rotation);

            }
        }
    }

    //Falta um pequeno ajuste no codigo abaixo, vou deixar comentado para o prof me helpar na segunda

//IEnumerator Pickup(Collider player)
// {
     //rb.drag = 1; // add pet dps

    //yield return new WaitForSeconds(1f);

       // rb.drag = 0.1f;
        
    //}

    //Não se pode usar trigger com input...

    //void OnTriggerEnter (Collider other)
 //{
     //if (Input.Fire)
        //{
            //GameObject received = itemReceived.GetItem();
           // if (received != null)
           // {
           //      if(itemReceived.count == 2)
           //     {
           //         StartCoroutine(Pickup(other));

            //    }

            //}
      //  }

 //}
    
    void GatherInputs()
    {
        // reset input

        Input = new InputData();


        // gather nonzero input from our sources
        for (int i = 0; i < m_Inputs.Length; i++)
        {
            Input = m_Inputs[i].GenerateInput();

        }
    }
}

