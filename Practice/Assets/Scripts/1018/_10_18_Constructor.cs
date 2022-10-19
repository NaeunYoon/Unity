using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class _10_18_Constructor : MonoBehaviour
{
    //이름, 나이
    public string name01 = "나은";
    public int age = 29;
    public static int number = 1;   //static은 초기화 해줘야함

    public void Sample01()
    {
        //생성자
        Debug.Log("생성자 시작");
    }

    public void ShowName()
    {
        Debug.Log("이름");
    }
    public void ShowNe()
    {
        Debug.Log("show ne");
    }
    public static void Sample02()
    {
        Debug.Log(number);  //static이 아닌 변수에 접근 불가능

        //Example ex = new Example();   //새로 메모리 할당 안해줘도 댐
        //ex.num = 30;

        Example.num = 30;
        Debug.Log(Example.num);
    }

    private void Start()
    {
        Sample02();
    }

}

public class Example{
    public static int num =30;
}
