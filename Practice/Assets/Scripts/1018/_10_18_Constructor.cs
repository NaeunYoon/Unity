using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class _10_18_Constructor : MonoBehaviour
{
    //�̸�, ����
    public string name01 = "����";
    public int age = 29;
    public static int number = 1;   //static�� �ʱ�ȭ �������

    public void Sample01()
    {
        //������
        Debug.Log("������ ����");
    }

    public void ShowName()
    {
        Debug.Log("�̸�");
    }
    public void ShowNe()
    {
        Debug.Log("show ne");
    }
    public static void Sample02()
    {
        Debug.Log(number);  //static�� �ƴ� ������ ���� �Ұ���

        //Example ex = new Example();   //���� �޸� �Ҵ� �����൵ ��
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
