using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed=8f; //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody; //�̵��� ����� ������ٵ� ������Ʈ(�߷»�� ����)
    //�ݶ��̴� ���� : �Ѿ��� �ٸ� ź�˿� �浹���� �� ƨ�ܳ����� �ʰ� �׳� ����ϵ��� Trigger üũ

    // Start is called before the first frame update
    void Start()
    {
        //Bullet ��ũ��Ʈ�� Ȱ��ȭ �� ��, Bullet Rigidbody ������Ʈ�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���ʹ��� * �̵��ӷ�
        bulletRigidbody.velocity = transform.forward*speed;
        //���� ���⿡ �̵��ӷ��� ���ؼ� ���� ������Ʈ�� ���� ����(z��)���� speed ��ŭ�� �ӵ��� ǥ���� ��
        //transform.forward �� Vector3Ÿ���� ����
        //transform ������Ʈ�� ���� ������Ʈ�� ��ġ ũ�� ȸ���� ����ϴ� ������Ʈ


        //3�� �ڿ� ���ӿ�����Ʈ �ı�
        //Destroy(gameObject, obj) : ������Ʈ �̸�
        //Destroy(gameObject obj,float t) : ������Ʈ �̸�, �ð�
        Destroy(gameObject,3f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) //other �� �浿�� ��� ���� ������Ʈ�� �ݶ��̴� ������Ʈ
    {
        //�浹�� ��� ������Ʈ�� player �±׸� ���� ���
        if (other.tag == "Player")
        {
            //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();

            //�������κ��� PlayerController ������Ʈ�� �������� �� �����ߴٸ�
            if (playerController != null)
            {       //���� PlayerController ������Ʈ�� Die �޼��� ���� 
                    playerController.Die();
            }
        }



    }

}
