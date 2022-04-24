using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class img : MonoBehaviour
{
    public static img imgInstance;

    public Sprite bola;
    public Sprite foguete;
    public Sprite coracao;
    public Sprite capacete;
    public Sprite raio;
    public Sprite nada;
    // ----------- Player1----------------
    public ItemReceived MtItem;
   public ItemReceived PetItem;
   public ItemReceived item3;
    // public ItemReceived item4;
    // public ItemReceived item5;
    // public ItemReceived item6;

    // player2
    public ItemReceived MtItem2;
    public ItemReceived PetItem2;

    public Image imagem;
    public Image imagem2;
    // SpriteRenderer spriteR;
    // Start is called before the first frame update
    void Start()
    {
       // GetComponent<Image>().sprite = bola;
       //imagem = GetComponentInChildren<Image>();
       // spriteR = GetComponent<SpriteRenderer>();
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (imgInstance == null)
        {
            imgInstance = this;
        }
        else
            DestroyObject(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        if(MtItem.itenPresent)
        {
        Troca();
        }else
            if(PetItem.itenPresent)
        {
        Troca2();
        }


        // player2
        if (MtItem2.itenPresent)
        {
            Troca();
        }
        else
            if (PetItem2.itenPresent)
        {
            Troca2();
        }



    }

    public void Troca()
    {
        if (MtItem.itenPresent)
        {
            if (MtItem.count == 0)
            {
                imagem.sprite = bola;
            }
            else
                    if (MtItem.count == 1)
            {
                imagem.sprite = capacete;
            }
            else
                    if (MtItem.count == 2)
            {
                imagem.sprite = raio;
            }
            else
                    if (MtItem.count == 3)
            {
                imagem.sprite = foguete;
            }
            else
                    if (MtItem.count == 4)
            {
                    imagem.sprite = coracao;

            }
        }
        else
            imagem.sprite = nada;
    }

    public void Troca2()
    {
        if (PetItem.itenPresent)
        {
            if (PetItem.count == 0)
            {
                imagem.sprite = bola;
            }
            else
                    if (PetItem.count == 1)
            {
                imagem.sprite = capacete;
            }
            else
                    if (PetItem.count == 2)
            {
                imagem.sprite = raio;
            }
            else
                    if (PetItem.count == 3)
            {
                imagem.sprite = foguete;
            }
            else
                    if (PetItem.count == 4)
            {
                imagem.sprite = coracao;
            }
        }else
            imagem.sprite = nada;
    }

    public void P2Troca()
    {
        if (MtItem2.itenPresent)
        {
            if (MtItem2.count == 0)
            {
                imagem2.sprite = bola;
            }
            else
                    if (MtItem2.count == 1)
            {
                imagem2.sprite = capacete;
            }
            else
                    if (MtItem2.count == 2)
            {
                imagem2.sprite = raio;
            }
            else
                    if (MtItem2.count == 3)
            {
                imagem2.sprite = foguete;
            }
            else
                    if (MtItem2.count == 4)
            {
                imagem2.sprite = coracao;

            }
        }
        else
            imagem2.sprite = nada;
    }

    public void P2Troca2()
    {
        if (PetItem2.itenPresent)
        {
            if (PetItem2.count == 0)
            {
                imagem2.sprite = bola;
            }
            else
                    if (PetItem2.count == 1)
            {
                imagem2.sprite = capacete;
            }
            else
                    if (PetItem2.count == 2)
            {
                imagem2.sprite = raio;
            }
            else
                    if (PetItem2.count == 3)
            {
                imagem2.sprite = foguete;
            }
            else
                    if (PetItem2.count == 4)
            {
                imagem2.sprite = coracao;
            }
        }
        else
            imagem2.sprite = nada;
    }
}
