using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCapacete : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * 50);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // print("recebido");
            Destroy(gameObject);
        }
    }

}