using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecao : MonoBehaviour
{
    public int select;
    public int stat = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void player2()
    {
        select = 0;
        stat = 2;
    }

    public void kart1()
    {
        select = 1;
    }

    public void kart2()
    {
        select = 2;
    }

    public void kart3()
    {
        select = 3;
    }

    public void kart4()
    {
        select = 4;
    }

    public void kart5()
    {
        select = 5;
    }

    public void kart6()
    {
        select = 6;
    }
}
