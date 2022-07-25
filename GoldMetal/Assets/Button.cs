using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
 

  
    void Update()
    {
        //Edit - Project Setting - Input Manager 에서 셋팅 가능
        //버튼을 받는 방법 GetButton : Input 버튼 입력을 받으면 true

        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다");

        if (Input.GetButton("Jump2"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump2"))
            Debug.Log("점프 모으는 중..");

        if (Input.GetButtonUp("Jump2"))
            Debug.Log("슈퍼 점프!");

        //마음대로 키를 입력 받을 수 있나요?

        if (Input.GetButton("SuperFire"))
            Debug.Log("지정키 Escape");

        //종/횡 이동

            if (Input.GetButton("Horizontal"))
            {
                //Debug.Log("횡 이동 중...");

                //GerAxis : 수평, 수직 입력을 받으면 float
                //반환타입은 float

                //Input.GetAxis("Horizontal");

                // =

                //중간값까지 나옴
                //Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));

                //가중치 제거
                //Object는 변수 transform을 항상 가지고 있음
                //Raw 추가
                //딱 떨어지는 값 출력함
                Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
            }
                


            if (Input.GetButton("Vertical"))
            {

                Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));

            }
                





        }
            

    }

