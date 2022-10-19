using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _1018_if : MonoBehaviour
{
   
    void Start()
    {
        IF_Remind();
    }
    
    private void IF_Remind()
    {
        /*
         1: 12/5
         2: 8/7
         3: 8/3
         4: 12/7
         */
        

        int num1 = 10; 
        int num2 = 5; 


        if (num1++ > 10 && --num2 < 5)  
        {
            Debug.Log($"À§{num1},{num2}");
        }
        else
        {
            Debug.Log($"¾Æ·¡{num1},{num2}");
        }

    }
    
    void Update()
    {
        
    }
}
