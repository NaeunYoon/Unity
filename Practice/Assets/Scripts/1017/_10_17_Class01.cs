using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class _10_17_Class01 : MonoBehaviour
{

    //1. 
    //public _10_17_Class02 c1;
    //public _10_17_Class02 c2;
    //public _10_17_Class02 c3;

    //2.
    /*public _10_17_Class02[] c;*/  //인스펙터창에서 배열의 크기를 할당해줌
    /*public _10_17_Class02[] c = new _10_17_Class02[3];*/  //3 => 갯수

    //3.
    /*public*/
    List<_10_17_Class02> list;  //크기가 무제한임

    /*
     1. 리스트 초기화해주기
     2. 리스트에 add해주기
     3. 리스트 변수 인덱스로 접근

     4. 리스트에 클래스를 넣기 위해서는 클래스를 먼저 new로 메모리 할당을 해준다
     5. 리스트 변수. add ( 클래스형변수) 로 추가해준다
     */

    private void Awake()
    {
        list = new List<_10_17_Class02>();

    }
    void Start()
    {
        //1.
        //Debug.Log(c1.number);
        //Debug.Log(c2.number);
        //Debug.Log(c3.number);

        //2.
        //c[0].number = 10;
        //c[1].number = 10;
        //c[2].number = 10;
        //Debug.Log(c[0].number);
        //Debug.Log(c[1].number);
        //Debug.Log(c[2].number);



    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   //1.
            //c1.number = 10;
            //Debug.Log(c1.number);
            //c2.number = 20;
            //Debug.Log(c2.number);
            //c3.number = 30;
            //Debug.Log(c3.number);

            //2.
            //c[0].number = 10;
            //Debug.Log(c[0].number);
            //c[1].number = 20;
            //Debug.Log(c[1].number);
            //c[2].number = 30;
            //Debug.Log(c[2].number);

            //list[0].a = 10;
            //list[1].a = 20;
            //list[2].a = 30;


        }
    }
}
