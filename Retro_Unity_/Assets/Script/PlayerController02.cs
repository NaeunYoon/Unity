using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController02 : MonoBehaviour
{
    public  Rigidbody playerRigedbody; //�̵��� ����� Rigedbody ������Ʈ
    //���ѱⰡ �Ѿ����� �ʵ��� ��������
    //Public ���� �����ϸ� ������ â���� ���� drag & drop �� �ʿ䰡 ����

    public float speed=8f; //�̵� �ӷ�

    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigedbody ������Ʈ�� ã�� playerRigedbody�� �Ҵ� => public�� private�� �ٲ��ֱ�
        //�ֳĸ� �̹� Start �Լ����� �Ҵ����� ����, ����Ƽ �����Ϳ��� ���� ������
        playerRigedbody = GetComponent<Rigidbody>();

        //����<>�� ���׸������. ���ϴ� Ÿ���� ����ϸ� Ŭ������ �޼��尡 �ش� Ÿ�Կ� ���� ������
        


    }

    // Update is called once per frame
    void Update()
    {
        //-----------------------------------------------------1�����: �������� ���� ���ϱ�(AddForce)
        // Input : ����� �Է��� �����ϴ� �Լ�
        // Input.GetKey(Keycode key) : Ű������ �ĺ��ڸ� Keycode�� �Է¹���,
        // �ش� Ű�� ������ ������ True, �ƴϸ�False 

        //���� ����Ű �Է��� ������ ���, z �������� ���ֱ�
        if (Input.GetKey(KeyCode.UpArrow)==true)
        {
            playerRigedbody.AddForce(0f,0f,speed);
        }
        //�Ʒ��� ����Ű �Է��� ������ ���, -z �������� ���ֱ�
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigedbody.AddForce(0f, 0f, -speed);
        }
        //������ ����Ű �Է��� ������ ���, x �������� ���ֱ�
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigedbody.AddForce(speed, 0f, 0f);
        }
        //���� ����Ű �Է��� ������ ���, -x �������� ���ֱ�
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigedbody.AddForce(-speed, 0f, 0f);
        }

        

        //=������ ����Ǿ� ���԰��� ������
        //AddForce�� ���� �߰��Ѵ�. ������ ������ �ӵ��� ���������� ������Ű�� ������,
        //�ӵ��� ����������� �ð��� �ɸ���. �̵��߿� ������ �ٲٴ� ���, ������ ���� ���� ���
        //=������ȯ�� ����

    }

    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        // gameobject �� ���� ������Ʈ�� ����
        // ������ gameobject�� false�� ����
        gameObject.SetActive(false);
    }

}
