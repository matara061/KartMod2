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

    // Start is called before the first frame update
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
                if(itemReceived.count == 1)
                {
                    Instantiate(received, target2.transform.position, target.transform.rotation);
                }else
                    if(itemReceived.count == 2)
                {
                    rb.AddForce(-transform.forward * 100000);
                   // car.TopSpeed -= 100;
                   // car.Acceleration -= 50;
                }
                else if(itemReceived.count == 3)
                {
                    rb.AddForce(transform.forward * 1000000);
                   // car.TopSpeed += 100;
                   // car.Acceleration += 50;
                }else 
                    if(itemReceived.count == 4 || itemReceived.count == 0)
            Instantiate(received, target.transform.position, target.transform.rotation);

            }
        }
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
