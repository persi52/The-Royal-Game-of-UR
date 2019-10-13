using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sprawdz(int piony)
    {
        if (piony == 0)
            GetComponent<Text>().enabled = true;
    }
}
