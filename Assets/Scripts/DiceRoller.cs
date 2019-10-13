using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Wartosci = new int[4]; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] Wartosci;
    public int DiceTotal;
    public bool blokuj = false;
    

    public void RzucKostka()
    {
        if (blokuj == false)
        {
            DiceTotal = Random.Range(1, 5);
            blokuj = true;
        }
    }
}
