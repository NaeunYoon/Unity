using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigedbody; //�̵��� ����� Rigedbody ������Ʈ
    public float speed=8f; //�̵� �ӷ�

    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigedbody ������Ʈ�� ã�� playerRigedbody�� �Ҵ� => public�� private�� �ٲ��ֱ�
        //�ֳĸ� �̹� Start �Լ����� �Ҵ����� ����, ����Ƽ �����Ϳ��� ���� ������
        playerRigedbody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        //------------------------------------------------------------------1�����

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

        //------------------------------------------------------------------2�����




    }

    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }

}
