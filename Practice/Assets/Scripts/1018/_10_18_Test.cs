using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_18_Test : MonoBehaviour
{
    public int num;
    void Start()
    {
        if (num >= 90 && num <= 100)
        {
            Debug.Log("A");
        }
        else if (num >= 80 && num < 90)
        {
            Debug.Log("B");
        }
        else if (num >= 70 && num < 80)
        {
            Debug.Log("C");
        }
        else if (num >= 60 && num < 70)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }





    }

    
    void Update()
    {
        
    }
}
