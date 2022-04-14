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
    Vector3 m_ZAxis;

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

        //Movimentar carro flutuando
        //m_ZAxis = new Vector3(15, 0, 0);
       
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

                if (itemReceived.count == 1) // Capacete
                {
                    Instantiate(received, target2.transform.position, target.transform.rotation);
                    GetComponent<ItemReceived>().itenPresent = false; // para o item desativar corretamente dps de utilizado ~ ajuda a resetar status
                }
                else

                    if (itemReceived.count == 2) // Raio
                {
                    StartCoroutine(Pickup());
                    Instantiate(pickupEffect2, transform.position, transform.rotation);
                    Instantiate(pickupEffect3, transform.position, transform.rotation);
                    GetComponent<ItemReceived>().itenPresent = false;

                }
                else if (itemReceived.count == 3)  // Foguete
                {
                    rb.AddForce(transform.forward * 1000000);
                    Instantiate(pickupEffect, transform.position, transform.rotation);
                    Instantiate(pickupEffect1, transform.position, transform.rotation);
                    GetComponent<ItemReceived>().itenPresent = false;
                }
                else
                    if (itemReceived.count == 0) // BolaEspinho
                {
                    Instantiate(received, target.transform.position, target.transform.rotation);
                    GetComponent<ItemReceived>().itenPresent = false;
                }
                else
                    if (itemReceived.count == 4 ) // Coração
                {
                    Instantiate(received, target.transform.position, target.transform.rotation);
                    StartCoroutine(Pickup2());
                    GetComponent<ItemReceived>().itenPresent = false;

                }


            }
        }

    }


    IEnumerator Pickup()
    {
        rb.drag = 1; 

        //Duração do efeito, dps desse tempo retorna ao status normal
        yield return new WaitForSeconds(2f);

        rb.drag = 0.1f;

    }

    IEnumerator Pickup2()
    {
        //Só uma pausinha para não executar tudo de uma vez
        yield return new WaitForSeconds(0.01f);

        //Congela a fisica do kart
        rb.constraints = RigidbodyConstraints.FreezePositionY;
        //rb.velocity = -m_ZAxis;

        yield return new WaitForSeconds(3f);

        //retorna a fisica do kart
        rb.constraints = RigidbodyConstraints.None;
    }


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

