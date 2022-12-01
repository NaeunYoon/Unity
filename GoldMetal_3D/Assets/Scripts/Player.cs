using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float hAxis;    //1. input Axis 를 받을 전역변수 선언
    float vAxis;    //2. input Axis 를 받을 전역변수 선언
    Vector3 moveVec;

    public GameObject[] weapons;
    public bool[] hasWeapon;

    public float speed;
    Animator anim;

    bool wDown;
    bool eDown;
    bool JDown; //-
    bool sDown1;
    bool sDown2;
    bool sDown3;
    bool isSwap;
    Rigidbody rb;

    bool isJump;
    bool isDodge;

    Vector3 DodgeVec; //회피할 때 못움직이도록

    GameObject nearObject;
    GameObject equipWeapon;
    int equipWeaponIndex=-1;

    //-------------------------------------5
    public int ammo;
    public int coin;
    public int health;
    public int hasGrenade;

    public int maxAmmo;
    public int maxCoin;
    public int maxHealth;
    public int maxHasGrenade;

    public GameObject[] hasGrenades;

    //-------------------------------------
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
        Interaction();
        Swap();
    }

    void GetInput()
    {
        //GetAxisRaw : Axis 값을 정수로 반환하는 함수 (Input Manager 에서 관리)
        hAxis = Input.GetAxisRaw("Horizontal"); //3.
        vAxis = Input.GetAxisRaw("Vertical");//4.

        wDown = Input.GetButton("Walk");      //누를때만 작동
        JDown = Input.GetButtonDown("Jump");
        eDown = Input.GetButtonDown("Interaction");
        sDown1 = Input.GetButtonDown("Swap1");
        sDown2 = Input.GetButtonDown("Swap2");
        sDown3 = Input.GetButtonDown("Swap3");
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;      //5.어떤 방향이든 1로 보정해주는 정규화 작업

        if (isDodge)
        {
            moveVec = DodgeVec; //회피하는 방향으로 바꿔준다
        }
        if (isSwap)
        {
            moveVec = Vector3.zero;
        }
        if (wDown)      //걸을 때 속도 느려짐
        {
            transform.position += moveVec * Time.deltaTime * 0.3f;
        }
        else
        {           //빨라짐
            transform.position += moveVec * Time.deltaTime * speed;
        }

        //또는 삼항연산자 사용

        //transform.position += moveVec * speed *(wDown ? 0.3f : 1f) * Time.deltaTime;

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
        if (JDown && moveVec == Vector3.zero && !isJump && !isDodge && !isSwap)   //내가 점프를 눌렀고, 점프가 false일 때만 실행
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
        if (JDown && moveVec != Vector3.zero &&!isJump && !isDodge && !isSwap)   //내가 점프를 눌렀고, 점프가 false일 때만 실행
        {
            DodgeVec = moveVec;
            speed *= 2f;
            anim.SetTrigger("doDodge");
            
            isDodge = true;

            Invoke("DodgeOut", 0.4f); //시간차 함수 호출
        }
    }

    void DodgeOut()
    {
        isDodge = false;
        speed *= 0.5f;
    }

    void Swap()
    {
        if(sDown1 && (!hasWeapon[0] || equipWeaponIndex == 0))
        {
            return;
        }
        if (sDown2 && (!hasWeapon[1] || equipWeaponIndex == 1))
        {
            return;
        }
        if (sDown3 && (!hasWeapon[2] || equipWeaponIndex == 2))
        {
            return;
        }


        int weaponIndex = -1;
        if (sDown1) weaponIndex = 0;
        if (sDown2) weaponIndex = 1;
        if (sDown3) weaponIndex = 2;

        if ((sDown1 || sDown2 || sDown3)&& !isJump && !isDodge )
        {
            if(equipWeapon != null)
            {
                equipWeapon.SetActive(false);

            }
            equipWeaponIndex = weaponIndex;
            equipWeapon = weapons[weaponIndex];
            equipWeapon.SetActive(true);

            anim.SetTrigger("doSwap");

            isSwap = true;

            Invoke("SwapOut",0.4f);
        }
    }

    void SwapOut()
    {
        isSwap = false;
    }
    void Interaction()
    {
        if(eDown==true && nearObject != null && !isJump && !isDodge)
        {
            Debug.Log("e");
            if (nearObject.tag == "Weapon")
            {
                Item item = nearObject.GetComponent<Item>();
                int weaponIndex = item.value;
                hasWeapon[weaponIndex]=true;

                Destroy(nearObject);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Weapon")
        {
            nearObject = other.gameObject;
            Debug.Log(nearObject.name);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Weapon")
        {
            nearObject = null;
        }
    }
    //---------------------------------------5

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            Item item = other.GetComponent<Item>();

            switch (item.type)
            {
                case Item.Type.Ammo:
                    ammo += item.value;
                    if (ammo > maxAmmo)
                    {
                        ammo = maxAmmo;
                    }
                    break;


                case Item.Type.Coin:
                    coin += item.value;
                    if(coin > maxCoin)
                    {
                        coin = maxCoin;
                    }

                    break;

                case Item.Type.Heart:
                    health += item.value;
                    if(health > maxHealth)
                    {
                        health = maxHealth;
                    }
                    
                    break;

                case Item.Type.Grende:

                    hasGrenade+=item.value;
                    if (hasGrenade > maxHasGrenade)
                    {
                        hasGrenade = maxHasGrenade;
                    }
                    break;
            }
            Destroy(other.gameObject); 
        }
    }



}
