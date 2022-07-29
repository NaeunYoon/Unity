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

        print("0번 학생의 점수 : " + students[0]);
        print("1번 학생의 점수 : " + students[1]);
        print("2번 학생의 점수 : " + students[2]);
        print("3번 학생의 점수 : " + students[3]);
        print("4번 학생의 점수 : " + students[4]);

        //--------------------------------------------------
        for(int i=0; i < students.Length; i++)
        {
            print((i) + "번 학생의 점수" + students[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
