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
    /*public _10_17_Class02[] c;*/  //�ν�����â���� �迭�� ũ�⸦ �Ҵ�����
    /*public _10_17_Class02[] c = new _10_17_Class02[3];*/  //3 => ����

    //3.
    /*public*/
    List<_10_17_Class02> list;  //ũ�Ⱑ ��������

    /*
     1. ����Ʈ �ʱ�ȭ���ֱ�
     2. ����Ʈ�� add���ֱ�
     3. ����Ʈ ���� �ε����� ����

     4. ����Ʈ�� Ŭ������ �ֱ� ���ؼ��� Ŭ������ ���� new�� �޸� �Ҵ��� ���ش�
     5. ����Ʈ ����. add ( Ŭ����������) �� �߰����ش�
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
