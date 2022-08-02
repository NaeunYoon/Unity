using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigedbody; //�̵��� ����� Rigedbody ������Ʈ
    public float speed = 8f; //�̵� �ӷ�

    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigedbody ������Ʈ�� ã�� playerRigedbody�� �Ҵ� => public�� private�� �ٲ��ֱ�
        //�ֳĸ� �̹� Start �Լ����� �Ҵ����� ����, ����Ƽ �����Ϳ��� ���� ������
        playerRigedbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()


    {   //������� �������� �Է°��� ����
        //GetAxis : � �࿡ ���� �Է°��� ���ڷ� ��ȯ�ϴ� �޼���
        //Input.GetAxis(string axisName) : �޼���� �� �̸��� �ް� ������ �Է°��� ��ȯ (-1 0 1) 

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵��ӵ��� �Է°��� �̵� �ӵ��� ����� ����
        float xSpeed=xInput*speed;
        float zSpeed=zInput*speed;

        //Vector3 �ӵ��� (xSpeed,0,xSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed,0,zSpeed);

        //������ٵ� �ӵ��� newVelocity �Ҵ�
        playerRigedbody.velocity = newVelocity;


        // AddForce : ���� �����ϰ� �ӷ��� ���������� ������Ŵ
        // Velocity : ������ �����ϰ� �ӵ��� ��� ����

        
    }
    public void Die()
    {
        
        gameObject.SetActive(false); ////�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        GameManager gameManager = FindObjectOfType<GameManager>();  // T���� �����ϴ� GameManagerŸ���� ������Ʈ�� ã�Ƽ� ��������
        gameManager.EndGame(); // ������ GameManager ������Ʈ�� Endgame()�޼��� ����

    }

}
