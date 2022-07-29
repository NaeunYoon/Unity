using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //캐릭터의 프로필을 변수로 만들기
        string characterName = "라라";
        char bloodType = 'A';
        int age = 17;
        float heigth = 163.8f;
        bool isFemale = true;

        //생성한 변수를 콘솔에 출력
        print("캐릭터 이름 :"+characterName);
        print("혈액형 :" + bloodType);
        print("나이 :" + age);
        print("키 :" + heigth);
        print("여성인가? :" + isFemale);

        //--------------------------------------------------------------------
        float distance = GetDistance(2, 2, 5, 6);
        print("(2,2)에서(5,6)까지의 거리: "+distance);
        //--------------------------------------------------------------------

        int love = 100;
        if (love > 70)
        {
            print("굿 엔딩 : 히로인과 사귀게 되었따");
        }
        if (love <= 70)
        {
            print("배드엔딩 : 히로인에게 차였다");
        }
        //--------------------------------------------------------------------
        int legalAge = 11;
        if (legalAge > 7 && legalAge < 18)
        {
            print("의무교육을 받고 있습니다");
        }
        if (legalAge < 13 || legalAge > 70)
        {
            print("일을 할 수 없는 나이입니다");
        }
        //---------------------------------------------------------------------
        for(int i = 0; i < 10; i++)
        {
            print(i + "번쨰 순번입니다");
        }
        //---------------------------------------------------------------------
        int j = 0;
        while (j < 10)
        {
            print(j + "번쨰 루프입니다");
        }
        //---------------------------------------------------------------------
        bool isDaed = false;
        int hp = 100;

        while(!isDaed)
        {
            print("현재체력" + hp);
            hp = hp - 33;
            if (hp <= 0)
            {
                isDaed = true;
                print("플레이어는 죽었습니다");
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
