using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Whale {

    public Whale()
    {

    }

    public override string ToString()   //����� �� �ڵ����� ����ȴ�.
    {
        return "�����Դϴ�";
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
