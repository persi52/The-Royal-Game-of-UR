using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WyswietlanieRzutu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        theDiceRoller = GameObject.FindObjectOfType<DiceRoller>();
    }

    DiceRoller theDiceRoller;
    // Update is called once per frame
    void Update()
    {

    }
    public void wyswietlRzut()
    {
        GetComponent<Text>().text = "= " + theDiceRoller.DiceTotal;
    }            
    public void wyzeruj()
    {
        GetComponent<Text>().text = "= ";
    }
}