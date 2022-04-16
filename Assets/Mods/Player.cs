using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player playerInstance;


    public StartManager startManager;
    public GameObject KartMT;
    public GameObject camMT;

    public GameObject kartPet;
    public GameObject camPet;

    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
            DestroyObject(gameObject);
    }
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
            kartPet.SetActive(false);
            camPet.SetActive(false);
            KartMT.SetActive(true);
            camMT.SetActive(true);
           
        }
        else
            if(startManager.kart1 == 2)
        {
            KartMT.SetActive(false);
            camMT.SetActive(false);
            kartPet.SetActive(true);
            camPet.SetActive(true);
           
        }
            
    }

}
