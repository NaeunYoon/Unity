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

        if (Input.GetButton("Jump2"))
            Debug.Log("����!");

        if (Input.GetButton("Jump2"))
            Debug.Log("���� ������ ��..");

        if (Input.GetButtonUp("Jump2"))
            Debug.Log("���� ����!");

        //������� Ű�� �Է� ���� �� �ֳ���?

        if (Input.GetButton("SuperFire"))
            Debug.Log("����Ű Escape");

        //��/Ⱦ �̵�

            if (Input.GetButton("Horizontal"))
            {
                //Debug.Log("Ⱦ �̵� ��...");

                //GerAxis : ����, ���� �Է��� ������ float
                //��ȯŸ���� float

                //Input.GetAxis("Horizontal");

                // =

                //�߰������� ����
                //Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));

                //����ġ ����
                //Object�� ���� transform�� �׻� ������ ����
                //Raw �߰�
                //�� �������� �� �����
                Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));
            }
                


            if (Input.GetButton("Vertical"))
            {

                Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));

            }
                





        }
            

    }

