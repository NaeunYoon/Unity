using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Whale {

    public Whale()
    {

    }

    public override string ToString()   //출력할 때 자동으로 실행된다.
    {
        return "나은입니다";
    }

}
public class KillogramSample : MonoBehaviour
{
   
    void Start()
    {
        Whale naeun = new Whale();
        Debug.Log(naeun);
    }


}
