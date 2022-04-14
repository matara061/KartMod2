using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public Selecao selected;
    public int kart1;
    public int kart2;
    public static StartManager startInstance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player1();
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (startInstance == null)
        {
            startInstance = this;
        }
        else
            DestroyObject(gameObject);
    }

    public void Player1()
    {
        if (selected.stat == 1)
            kart1 = selected.select;
        else
            kart2 = selected.select;
    }
}
