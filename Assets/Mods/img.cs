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
    public ItemReceived item;
    public Image imagem;
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
    }

    public void Troca()
    {
        if (item.itenPresent)
        {
        if (item.count == 0)
        {
            imagem.sprite = bola;
        }else
                if(item.count == 1)
            {

            }else
                if (item.count == 2)
            {

            }else
                if(item.count == 3)
            {

            }else
                if(item.count == 4)
            {

            }
        }
    }
}
