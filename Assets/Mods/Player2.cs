using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public static Player2 player2Instance;


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
    public GameObject CamJ;

    public GameObject CuboT;
    public GameObject CamT;

    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (player2Instance == null)
        {
            player2Instance = this;
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
        if (startManager.kart2 == 1)
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
            CamJ.SetActive(false);

            CuboT.SetActive(false);
            CamT.SetActive(false);
        }
        else
            if (startManager.kart2 == 2)
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
            CamJ.SetActive(false);
            CuboT.SetActive(false);
            CamT.SetActive(false);

        }
        else if (startManager.kart2 == 3)
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
            CamJ.SetActive(false);
            CuboT.SetActive(false);
            CamT.SetActive(false);
        }

        else if (startManager.kart2 == 4)
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
            CamJ.SetActive(false);
            CuboT.SetActive(false);
            CamT.SetActive(false);
        }
        else if (startManager.kart2 == 5)
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
            CamJ.SetActive(true);
            CuboT.SetActive(false);
            CamT.SetActive(false);
        }
        else if (startManager.kart2 == 6)
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
            CamJ.SetActive(false);
            CuboT.SetActive(true);
            CamT.SetActive(true);
        }

    }
}
