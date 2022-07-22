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

        if (Input.GetButton("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중..");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!");

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    playerRigidbody.AddForce(0, 500, 0);
        //}
    }
}
