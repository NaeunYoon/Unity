using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        print("0�� �л��� ���� : " + students[0]);
        print("1�� �л��� ���� : " + students[1]);
        print("2�� �л��� ���� : " + students[2]);
        print("3�� �л��� ���� : " + students[3]);
        print("4�� �л��� ���� : " + students[4]);

        //--------------------------------------------------
        for(int i=0; i < students.Length; i++)
        {
            print((i) + "�� �л��� ����" + students[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
