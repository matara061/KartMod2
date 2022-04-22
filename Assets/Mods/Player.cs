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

    public GameObject kartBe;
    public GameObject camBe;

    public GameObject KartAki;
    public GameObject camAki;

    public GameObject KartJoao;
    public GameObject camJoa;

    public GameObject CuboT;
    public GameObject camTia;

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
            kartBe.SetActive(false);
            camBe.SetActive(false);
            KartAki.SetActive(false);
            camAki.SetActive(false);
            KartJoao.SetActive(false);
            camJoa.SetActive(false);
            CuboT.SetActive(false);
            camTia.SetActive(false);
        }
        else
            if (startManager.kart1 == 2)
        {
            KartMT.SetActive(false);
            camMT.SetActive(false);
            kartPet.SetActive(true);
            camPet.SetActive(true);
            kartBe.SetActive(false);
            camBe.SetActive(false);
            KartAki.SetActive(false);
            camAki.SetActive(false);
            KartJoao.SetActive(false);
            camJoa.SetActive(false);
            CuboT.SetActive(false);
            camTia.SetActive(false);

        }
        else if (startManager.kart1 == 3)
        {
            KartMT.SetActive(false);
            camMT.SetActive(false);
            kartPet.SetActive(false);
            camPet.SetActive(false);
            kartBe.SetActive(true);
            camBe.SetActive(true);
            KartAki.SetActive(false);
            camAki.SetActive(false);
            KartJoao.SetActive(false);
            camJoa.SetActive(false);
            CuboT.SetActive(false);
            camTia.SetActive(false);
        }
        else if (startManager.kart1 == 4)
        {
            KartMT.SetActive(false);
            camMT.SetActive(false);
            kartPet.SetActive(false);
            camPet.SetActive(false);
            kartBe.SetActive(false);
            camBe.SetActive(false);
            KartAki.SetActive(true);
            camAki.SetActive(true);
            KartJoao.SetActive(false);
            camJoa.SetActive(false);
            CuboT.SetActive(false);
            camTia.SetActive(false);
        }
        else if (startManager.kart1 == 5)
        {
            KartMT.SetActive(false);
            camMT.SetActive(false);
            kartPet.SetActive(false);
            camPet.SetActive(false);
            kartBe.SetActive(false);
            camBe.SetActive(false);
            KartAki.SetActive(false);
            camAki.SetActive(false);
            KartJoao.SetActive(true);
            camJoa.SetActive(true);
            CuboT.SetActive(false);
            camTia.SetActive(false);
        }
        else if (startManager.kart1 == 6)
        {
            KartMT.SetActive(false);
            camMT.SetActive(false);
            kartPet.SetActive(false);
            camPet.SetActive(false);
            kartBe.SetActive(false);
            camBe.SetActive(false);
            KartAki.SetActive(false);
            camAki.SetActive(false);
            KartJoao.SetActive(false);
            camJoa.SetActive(false);
            CuboT.SetActive(true);
            camTia.SetActive(true);
        }

    }

}
