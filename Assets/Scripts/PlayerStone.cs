using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStone : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        theDiceRoller = GameObject.FindObjectOfType<DiceRoller>();
        target = GameObject.FindObjectOfType<zmianaGracza>();
        target1 = GameObject.FindObjectOfType<WyswietlanieRzutu>();
        winner = GameObject.FindObjectOfType<Winner>();
        startPosition = this.transform.position;        
    }


    public Tile StartingTile;
    Vector3 startPosition;
    Tile currentTile,zapasowe;
    DiceRoller theDiceRoller;
    zmianaGracza target;
    WyswietlanieRzutu target1;
    Winner winner;
    
    
   


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gracz);
    }
    public void OnMouseUp()
    {
        if (theDiceRoller.DiceTotal != 0)
        {
            //Debug.Log(gracz);
            if ((this.tag == "Player2" && target.gracz == 2) || (this.tag == "Player1" && target.gracz == 1))
            {

                    zapasowe = currentTile;
                    int spacesToMove = theDiceRoller.DiceTotal;

                    for (int i = 0; i < spacesToMove; i++)
                    {


                        if (currentTile == null)
                        {
                            currentTile = StartingTile;
                        }
                        else
                        {
                            if (currentTile.NextTiles == null || currentTile.NextTiles.Length == 0)
                                break;

                            else
                            {
                                                         
                                if (this.tag == "Player1")
                                    currentTile = currentTile.NextTiles[0];
                                else if (this.tag == "Player2" && currentTile.NextTiles.Length != 2)
                                    currentTile = currentTile.NextTiles[0];
                                else
                                    currentTile = currentTile.NextTiles[1];
                            }

                        }


                    }
                
                

                

                

                if (currentTile.NextTiles.Length != 0 || currentTile.NextTiles == null)
                {
                    if (this.tag == "Player1" && currentTile.zajete != 1 || this.tag == "Player2" && currentTile.zajete != 2)
                    {
                        this.transform.position = currentTile.transform.position;
                        this.transform.Translate(0, .65f, 0);
                        rzuty();                        
                    }
                    else
                    currentTile = zapasowe;
                    
                    
                }
                else
                {
                    Destroy(gameObject);
                    Debug.Log("score!");
                    currentTile = zapasowe;
                    currentTile.zajete = 0;
                    rzuty();
                    if (target.gracz == 1)
                    {
                        target.piony1--;
                        winner.sprawdz(target.piony1);
                        Debug.Log(target.piony1);
                    }
                    else
                    {
                        target.piony2--;
                        winner.sprawdz(target.piony2);
                        Debug.Log(target.piony2);
                    }
                }







            }

            //if (currentTile.NextTiles.Length != 0)
            //{
            // if (this.tag == "Player1" && a == 1)
            //{ 
            //if (a == 1 && this.tag == "Player1")


            //}
            //// else if (this.tag == "Player2" && a == 2)
            //{
            // this.transform.position = currentTile.transform.position;
            //this.transform.Translate(0, .65f, 0);
            // target.cyferka();
            //target1.wyzeruj();
            //theDiceRoller.blokuj = false;
            //  theDiceRoller.DiceTotal = 0;
            // a = 1;
            //}
            //else if(this.tag =="Player1" && a==2) 
            //else if(this.tag =="Player1" && a==1) 





            //}
            /// else
            //{
            //    Destroy(gameObject);
            //}



            //Debug.Log(currentTile.zajete);

        }
        //Debug.Log(gracz);
    }
    public void wracaj()
    {
        this.transform.position = startPosition;
        currentTile = null;
    }
    void rzuty()
    {               
             target.cyferka();
             target1.wyzeruj();
             theDiceRoller.blokuj = false;
             theDiceRoller.DiceTotal = 0;
             
            if (target.gracz == 1)
                target.gracz = 2;
             else
                target.gracz = 1;
    }
    
   
}


