using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;

    Vector3 moveVec;

    Animator anim;

    bool wDown;

    bool JDown;

    Rigidbody rb;

    bool isJump;
    bool isDodge;

    Vector3 DodgeVec; //ȸ���� �� �������̵���

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();          //�ڽĿ�����Ʈ�� ������
        rb=GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {

        GetInput();
        Move();
        Turn();
        Jump();
        Dodge();
    }

    void GetInput()
    {
        //GetAxisRaw : Axis ���� ������ ��ȯ�ϴ� �Լ� (Input Manager ���� ����)
        //����1 ����1 �̸� �밢���� ��Ʈ2
        hAxis = Input.GetAxisRaw("Horizontal"); //���������� �������� ���
        vAxis = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("Walk");      //�������� �۵�
        JDown = Input.GetButtonDown("Jump");
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;      //� �����̵� 1�� �������ִ� ����ȭ �۾�

        if (isDodge)
        {
            moveVec = DodgeVec;
        }

        //if (wDown)      //���� �� �ӵ� ������
        //{
        //    transform.position += moveVec * Time.deltaTime * 0.3f;
        //}
        //else{           //������
        //    transform.position += moveVec * Time.deltaTime * speed;
        //}

        //�Ǵ� ���׿����� ���

        transform.position += moveVec * speed *(wDown ? 0.3f : 1f) * Time.deltaTime;

        anim.SetBool("isRun", moveVec != Vector3.zero);
        anim.SetBool("isWalk", wDown);

    }

    void Turn()
    {

        //LookAt ������ ���͸� ���ؼ� ȸ�������ִ� �Լ�
        transform.LookAt(transform.position + moveVec); //���ư��� �������� �ٶ󺻴�
    }

    void Jump()
    {
        if (JDown && moveVec ==Vector3.zero && !isJump && !isDodge)   //���� ������ ������, ������ false�� ���� ����
        {
            rb.AddForce(Vector3.up*15f,ForceMode.Impulse);  //���������� ���� ���� �������� 
            anim.SetBool("isJump", true);
            anim.SetTrigger("doJump");
            isJump = true;
        }
    }
    private void OnCollisionEnter(Collision collision)  //�浹������ ����
    {
        //�ٴڿ� ����� �� ���� ����
        if(collision.gameObject.tag == "Floor")
        {
            anim.SetBool("isJump", false);
            isJump = false;
        }
    }

    void Dodge()
    {
        if (JDown && moveVec != Vector3.zero &&!isJump && !isDodge)   //���� ������ ������, ������ false�� ���� ����
        {
            DodgeVec = moveVec;
            speed *= 2f;
            anim.SetTrigger("doDodge");
            
            isDodge = true;

            Invoke("DodgeOut", 0.4f);
        }
    }

    void DodgeOut()
    {
        isDodge = false;
        speed *= 0.5f;
    }


}
