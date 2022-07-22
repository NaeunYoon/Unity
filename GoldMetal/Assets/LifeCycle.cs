using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //�ʱ�ȭ->(Ȱ��ȭ)->��������->���ӷ���->(��Ȱ��ȭ)->��ü

    void Awake()
    {
        //Awake : ���� ������Ʈ ������ �� ���� ���� ( �� �ѹ��� ���� �� )

        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�"); //�ʱ�ȭ����


    }
    private void OnEnable()
    {
        //���� ������Ʈ�� Ȱ��ȭ �Ǿ��� �� (���� ������ �ƴ� Ű�� �� ������ ������ �ȴ�)
        Debug.Log("�÷��̾ �α��� �߽��ϴ�");
    }

    // Start is called before the first frame update
    void Start()
    {
        //Start : ������Ʈ ���� ��, ���� ����

        Debug.Log("��� ��� ì����ϴ�"); //�ʱ�ȭ����
    }

    void FixedUpdate()
    {
        //FixedUpdate :���� ���� ������Ʈ(������ ���� �ֱ��CPU�� ���� ��� : CPU ���ϰ� ����)
        //���� 1�ʿ� 50ȸ ȣ���� �ȴ�
        Debug.Log("�̵�~");

    }

    // Update is called once per frame
    void Update()
    {
        //1�ʿ� ������ �۵��ϴ� �Լ� ���� ���� ������Ʈ ( �ֱ������� ���ϴ� ������ ���� �� ����ϴ� �Լ�)
        //ȯ�濡 ���� ���� �ֱⰡ ������ �� ���� (FIXEDUPDATE���� ����)
        Debug.Log("���� ���!");
        //UPDATE�� FIXED������Ʈ���� ��Ȳ�� ���� �� ����/������ �� �� �ִ�

    }

    private void LateUpdate()
    {
        //��� ������Ʈ ���� �� ���������� ȣ��Ǵ� �Լ�
        //���� ĳ���͸� ���󰡴� ī�޶�, ������ �� ó��
        Debug.Log("����ġ ȹ��");
        //������Ʈ�� ���� Ƚ���� �ö󰣴�

    }
    private void OnDisable()
    {//���ӿ�����Ʈ�� ��Ȱ��ȭ �Ǿ��� ��
        Debug.Log("�÷��̰� �α׾ƿ� �߽��ϴ�");
        //��ũ��Ʈ�� ���� ��Ȱ��ȭ ��
    }

    private void OnDestroy()
    {
        //���� ������Ʈ�� ������ ��, ������ ����� �������

        Debug.Log("�÷��̾� �����͸� ��ü�Ͽ����ϴ�");
        //�÷��� �߿� �÷��̾� ������Ʈ�� �����Ǹ� ����ȴ�
    }

}
