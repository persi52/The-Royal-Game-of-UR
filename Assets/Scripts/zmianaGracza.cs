using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zmianaGracza : MonoBehaviour
{
    public int gracz = 1;
    public int piony1 = 6, piony2 = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cyferka()
    {
        if (gracz == 1)
        GetComponent<Text>().text = "Tura gracza: Niebieski";          
        else
        GetComponent<Text>().text = "Tura gracza: Czerwony";       
    }        
}
