using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
 

  
    void Update()
    {
        //Edit - Project Setting - Input Manager ���� ���� ����
        //��ư�� �޴� ��� GetButton : Input ��ư �Է��� ������ true

        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�");

        if (Input.GetButton("Jump"))
            Debug.Log("����!");

        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��..");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!");

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    playerRigidbody.AddForce(0, 500, 0);
        //}
    }
}
