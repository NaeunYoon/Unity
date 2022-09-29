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

    Vector3 DodgeVec; //회피할 때 못움직이도록

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();          //자식오브젝트가 가져옴
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
        //GetAxisRaw : Axis 값을 정수로 반환하는 함수 (Input Manager 에서 관리)
        //세로1 가로1 이면 대각선은 루트2
        hAxis = Input.GetAxisRaw("Horizontal"); //뒤집어져서 제약조건 사용
        vAxis = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("Walk");      //누를때만 작동
        JDown = Input.GetButtonDown("Jump");
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;      //어떤 방향이든 1로 보정해주는 정규화 작업

        if (isDodge)
        {
            moveVec = DodgeVec;
        }

        //if (wDown)      //걸을 때 속도 느려짐
        //{
        //    transform.position += moveVec * Time.deltaTime * 0.3f;
        //}
        //else{           //빨라짐
        //    transform.position += moveVec * Time.deltaTime * speed;
        //}

        //또는 삼항연산자 사용

        transform.position += moveVec * speed *(wDown ? 0.3f : 1f) * Time.deltaTime;

        anim.SetBool("isRun", moveVec != Vector3.zero);
        anim.SetBool("isWalk", wDown);

    }

    void Turn()
    {

        //LookAt 지정된 벡터를 향해서 회전시켜주는 함수
        transform.LookAt(transform.position + moveVec); //나아가는 방향으로 바라본다
    }

    void Jump()
    {
        if (JDown && moveVec ==Vector3.zero && !isJump && !isDodge)   //내가 점프를 눌렀고, 점프가 false일 때만 실행
        {
            rb.AddForce(Vector3.up*15f,ForceMode.Impulse);  //무한점프를 막기 위한 제약조건 
            anim.SetBool("isJump", true);
            anim.SetTrigger("doJump");
            isJump = true;
        }
    }
    private void OnCollisionEnter(Collision collision)  //충돌정보를 얻음
    {
        //바닥에 닿았을 때 착지 구현
        if(collision.gameObject.tag == "Floor")
        {
            anim.SetBool("isJump", false);
            isJump = false;
        }
    }

    void Dodge()
    {
        if (JDown && moveVec != Vector3.zero &&!isJump && !isDodge)   //내가 점프를 눌렀고, 점프가 false일 때만 실행
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
