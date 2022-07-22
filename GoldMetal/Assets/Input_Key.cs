using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Key : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        //Input : ���� �� �Է��� �����ϴ� Ŭ����
        //anyKeyDown : �ƹ� �Է��� ���ʷ� ���� �� true, ���� ���� �ϰ� ���� ���콺�� Ű���� �ƹ��ų� ������ ȣ��
                        //���콺�� ���� Ű���� �ƹ��ų� ������ ����� ��
                        //����Ÿ���� bool��
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�");

        //anyKey : �ƹ� �Է��� ������ true = ������ �ֽ��ϴ�
        //������ ������ ���ڰ� �ö�
        if (Input.anyKey)
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�");

        //---------------------------------------------------------------------------------------
        
        //�Է¹�� : ������(Down), ������ ������ �ֱ�(Stay), ���� ���(Up)

        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�");

        //Ű���� Ű

        //GetKey : Ű���� ��ư �Է��� ������ true
        //�Ű������� KeyCode + . + Ű���� Ű�� ���� ����
                                    // return : Enter
                                    // LeftArrow : ���� ����Ű
                                    // RighrArrow : ������ ����Ű
                                    // Escape : ESC
                                    // W : WŰ
        
        if(Input.GetKeyDown(KeyCode.Return))
            Debug.Log("�������� �����Ͽ����ϴ�");
        //�� ������ ���� ��
        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��");
        //�� ������ ���
        if(Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵��� ���߾����ϴ�");


        //���콺 Ű 
        //GetMouse : ���콺 �Է��� ������ true
        //GetMouseButtonDown : ���콺 �ѹ� ���� ��
        //GetMouseButton : �� ������ ���� ��
        //GetMouseButtonUp : ���콺���� �� �� ��

        //�Ű������� ���ڷ� �޴´� 0: ���콺 ���� ��ư, 1: ���콺 ������ ��ư

        if (Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� �߻�");
        //�� ������ ���� ��
        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��...");
        //�� ������ ���
        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!");


        






    }
}
