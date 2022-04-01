using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject meshObject;
    public AudioSource audio;
    bool coolDawn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshObject.transform.Rotate(0, Time.deltaTime * 20, 0);
        meshObject.transform.Translate(0, Mathf.Sin(Time.time*5)*0.01f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !coolDawn)
        {
           // print("item");
            audio.Play();
            meshObject.SetActive(false);
            coolDawn = true;
            Invoke("ReturnCoolDown", 3);

            other.gameObject.SendMessage("Receive");
        }
    }

    void ReturnCoolDown()
    {
        coolDawn = false;
        meshObject.SetActive(true);
    }
}
