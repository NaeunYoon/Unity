using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Tranform : ������Ʈ ���¿� ���� �⺻ ������Ʈ, ������Ʈ�� Ʈ�������� 1:1 ���� (��ġ ȸ�� ũ��) , �ϳ��� Ŭ����

        //Ʈ�������� �����ؼ� �ʱ�ȭ �� �ʿ䰡 ���� Transform tr; ����Ƽ�� �˾Ƽ� ��������

        //������Ʈ�� ���� transform�� �׻� ������ ����

        //Ŭ���� �̸��� �빮�� Transform ���� �̸��� �ҹ��� transform

        //������Ʈ�� ���콺 ���� ��ư���� ���� ����

        //Translate : ���� ���� ���� ��ġ�� ���ϴ� �Լ�


        //int num = 4; �� ���� �ܼ��� ���� ���а迡���� ��Į�� ���̶�� �θ�
        //�ܼ��� ���� ���Ⱚ�� �־����� �װ��� �����̴�
        //���� : ������׿� ���� ũ�� ��

       Vector3 vec = new Vector3(5,0,0);
        //���Ͱ� ���� �� ���� (x,y,z);   //2������ 2���� ������ ��
        //����� ũ�⸦ ��� ������ �ֱ� ������ ���Ͱ��̶�� �Ѵ�.
        //�Ϲ� ������ �ٸ��� new�� ����ؾ���
        //Translate�� ���� ���ؼ��� vector3�� �־�� ��

        transform.Translate(vec);
        //x�� ������ 5��ŭ ��
        //Translate�� �� �״�� �̵��Ѵٴ� �ǹ��� = ��ŭ �̵��� �ϴ���
        //vec�� ũ�⸸ŭ �̵��� �ϱ� ������ 000�� ���� �̵��� ���� ���� (��ġ�� ���ϱ⸦ ��)





    }

    // Update is called once per frame
    void Update()
    {

        //1�ʿ� 60ȸ�� ������

        //Vector3 vec = new Vector3(0.01f, 0, 0);
        //transform.Translate(vec);

        //����ī�޶� ��ũ��Ʈ�� ������ ������Ʈ�� ī�޶� ���� �ö�

        //--------------------------------����Ű ����ؼ� �̵�

        //�߰��� �ִ� ver
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);

        //�߰� �� ���� ver

        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        //transform.Translate(vec);

    }
}
