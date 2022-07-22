using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Key : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        //Input : 게임 내 입력을 관리하는 클래스
        //anyKeyDown : 아무 입력을 최초로 받을 때 true, 게임 실행 하고 나서 마우스나 키보드 아무거나 누르면 호출
                        //마우스나 숫자 키보드 아무거나 누르면 출력이 됨
                        //리턴타입이 bool값
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다");

        //anyKey : 아무 입력을 받으면 true = 누르고 있습니다
        //누르고 있으면 숫자가 올라감
        if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다");

        //---------------------------------------------------------------------------------------
        
        //입력방식 : 누르기(Down), 누르고 가만히 있기(Stay), 손을 뗴기(Up)

        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다");

        //키보드 키

        //GetKey : 키보드 버튼 입력을 받으면 true
        //매개변수는 KeyCode + . + 키보드 키를 선택 가능
                                    // return : Enter
                                    // LeftArrow : 왼쪽 방향키
                                    // RighrArrow : 오른쪽 방향키
                                    // Escape : ESC
                                    // W : W키
        
        if(Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다");
        //꾹 누르고 있을 떄
        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");
        //꾹 누르다 뗴면
        if(Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다");


        //마우스 키 
        //GetMouse : 마우스 입력을 받으면 true
        //GetMouseButtonDown : 마우스 한번 누를 때
        //GetMouseButton : 꾹 누르고 있을 떄
        //GetMouseButtonUp : 마우스에서 손 뗄 때

        //매개변수는 숫자로 받는다 0: 마우스 왼쪽 버튼, 1: 마우스 오른쪽 버튼

        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사");
        //꾹 누르고 있을 떄
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");
        //꾹 누르다 뗴면
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!");


        






    }
}
