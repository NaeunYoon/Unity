using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ĳ������ �������� ������ �����
        string characterName = "���";
        char bloodType = 'A';
        int age = 17;
        float heigth = 163.8f;
        bool isFemale = true;

        //������ ������ �ֿܼ� ���
        print("ĳ���� �̸� :"+characterName);
        print("������ :" + bloodType);
        print("���� :" + age);
        print("Ű :" + heigth);
        print("�����ΰ�? :" + isFemale);

        //--------------------------------------------------------------------
        float distance = GetDistance(2, 2, 5, 6);
        print("(2,2)����(5,6)������ �Ÿ�: "+distance);
        //--------------------------------------------------------------------

        int love = 100;
        if (love > 70)
        {
            print("�� ���� : �����ΰ� ��Ͱ� �Ǿ���");
        }
        if (love <= 70)
        {
            print("��忣�� : �����ο��� ������");
        }
        //--------------------------------------------------------------------
        int legalAge = 11;
        if (legalAge > 7 && legalAge < 18)
        {
            print("�ǹ������� �ް� �ֽ��ϴ�");
        }
        if (legalAge < 13 || legalAge > 70)
        {
            print("���� �� �� ���� �����Դϴ�");
        }
        //---------------------------------------------------------------------
        for(int i = 0; i < 10; i++)
        {
            print(i + "���� �����Դϴ�");
        }
        //---------------------------------------------------------------------
        int j = 0;
        while (j < 10)
        {
            print(j + "���� �����Դϴ�");
        }
        //---------------------------------------------------------------------
        bool isDaed = false;
        int hp = 100;

        while(!isDaed)
        {
            print("����ü��" + hp);
            hp = hp - 33;
            if (hp <= 0)
            {
                isDaed = true;
                print("�÷��̾�� �׾����ϴ�");
            }
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float GetDistance(float x1, float y1,float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width*width+ height*height;
        distance = Mathf.Sqrt(distance);

        return distance;

    }
}
