using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisExample : MonoBehaviour
{
    private static ThisExample _instance;




    void Start()
    {
        //Debug.Log(this.gameObject.name); //ť�� ���� �ι� � ť��
        //Destroy(this);


        if(_instance == null)
        {
            _instance = this;
        }

    }


    void Update()
    {
        
    }
}
