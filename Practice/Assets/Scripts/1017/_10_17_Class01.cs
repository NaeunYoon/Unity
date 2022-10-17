using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class _10_17_Class01 : MonoBehaviour
{

    //public _10_17_Class02 c1;
    //public _10_17_Class02 c2;
    //public _10_17_Class02 c3;

    //public _10_17_Class02[] c;

    /*public*/ List<_10_17_Class02> list;

    private void Awake()
    {
        list = new List<_10_17_Class02>();
    }
    void Start()
    {
        //c[0].a = 10;
        //c[1].a = 10;
        //c[2].a = 10;

        

    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //c1.a = 10;
            //Debug.Log(c1.a);
            //c2.a = 20;
            //Debug.Log(c2.a);
            //c3.a = 30;
            //Debug.Log(c3.a);

            //c[0].a = 10;
            //debug.log(c[0].a);
            //c[1].a = 20;
            //debug.log(c[1].a);
            //c[2].a = 30;
            //debug.log(c[2].a);

            list[0].a = 10;
            list[1].a = 20;
            list[2].a = 30;


        }
    }
}
