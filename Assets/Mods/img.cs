using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class img : MonoBehaviour
{

    public Sprite bola;
    public Sprite foguete;
    public Sprite coracao;
    public Sprite capacete;
    public Sprite raio;
    public Sprite nada;
    public ItemReceived item;
    public ItemReceived item2;
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

    // Update is called once per frame
    void Update()
    {
        Troca();
        Troca2();
    }

    public void Troca()
    {
        if (item.itenPresent)
        {
            if (item.count == 0)
            {
                imagem.sprite = bola;
            }
            else
                    if (item.count == 1)
            {

            }
            else
                    if (item.count == 2)
            {

            }
            else
                    if (item.count == 3)
            {

            }
            else
                    if (item.count == 4)
            {
                    imagem.sprite = coracao;

            }
        }
        else
            imagem.sprite = nada;
    }

    public void Troca2()
    {
        if (item2.itenPresent)
        {
            if (item2.count == 0)
            {
                imagem2.sprite = bola;
            }
            else
                    if (item2.count == 1)
            {

            }
            else
                    if (item2.count == 2)
            {

            }
            else
                    if (item2.count == 3)
            {

            }
            else
                    if (item2.count == 4)
            {
                imagem2.sprite = coracao;
            }
        }else
            imagem2.sprite = nada;
    }
}
