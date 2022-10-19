using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class _10_18_Inherit 
//{
   
    
//}
public class Animal : MonoBehaviour
{ 
    public int age = 10;
    public void Speak()
    {
        Debug.Log("부모스피크");
    }
}

public class Dog : Animal
{

}

