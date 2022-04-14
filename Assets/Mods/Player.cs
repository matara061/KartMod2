using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public StartManager startManager;
    public GameObject KartMT;
    public GameObject kartPet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        kart();
    }

    public void kart()
    {
        if (startManager.kart1 == 1)
        {
            KartMT.SetActive(true);
        }
        else
            if(startManager.kart1 == 2)
        {
            kartPet.SetActive(true);
        }
            
    }
}
