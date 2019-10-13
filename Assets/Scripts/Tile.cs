using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
       
    }


    public Tile[] NextTiles;
    public Collider other2 = null;    

    public int zajete = 0;
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player2")
            {
            if (zajete == 1 && other2 != null)
                {
                other2.SendMessage("wracaj");
                other2 = other;               
                }
            else
                {
                other2 = other;
                }

            zajete = 2;


        }
        else if(other.tag == "Player1")
        {
            if (zajete == 2 && other2 != null)
            {
                other2.SendMessage("wracaj");
                other2 = other;
            }
            else
            {
                other2 = other;
            }

            zajete = 1;


        }
        
        
    }



    void OnTriggerExit(Collider other)
    {
        
            if(other.tag=="Player1" && zajete ==1)
            zajete = 0;
            if (other.tag == "Player2" && zajete == 2)
            zajete = 0;
        
    }
}

