using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float hAxis;    //1. input Axis �� ���� �������� ����
    float vAxis;    //2. input Axis �� ���� �������� ����
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

    Vector3 DodgeVec; //ȸ���� �� �������̵���

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
        Interaction();
        Swap();
    }

    void GetInput()
    {
        //GetAxisRaw : Axis ���� ������ ��ȯ�ϴ� �Լ� (Input Manager ���� ����)
        hAxis = Input.GetAxisRaw("Horizontal"); //3.
        vAxis = Input.GetAxisRaw("Vertical");//4.

        wDown = Input.GetButton("Walk");      //�������� �۵�
        JDown = Input.GetButtonDown("Jump");
        eDown = Input.GetButtonDown("Interaction");
        sDown1 = Input.GetButtonDown("Swap1");
        sDown2 = Input.GetButtonDown("Swap2");
        sDown3 = Input.GetButtonDown("Swap3");
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;      //5.� �����̵� 1�� �������ִ� ����ȭ �۾�

        if (isDodge)
        {
            moveVec = DodgeVec; //ȸ���ϴ� �������� �ٲ��ش�
        }
        if (isSwap)
        {
            moveVec = Vector3.zero;
        }
        if (wDown)      //���� �� �ӵ� ������
        {
            transform.position += moveVec * Time.deltaTime * 0.3f;
        }
        else
        {           //������
            transform.position += moveVec * Time.deltaTime * speed;
        }

        //�Ǵ� ���׿����� ���

        //transform.position += moveVec * speed *(wDown ? 0.3f : 1f) * Time.deltaTime;

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
        if (JDown && moveVec == Vector3.zero && !isJump && !isDodge && !isSwap)   //���� ������ ������, ������ false�� ���� ����
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
        if (JDown && moveVec != Vector3.zero &&!isJump && !isDodge && !isSwap)   //���� ������ ������, ������ false�� ���� ����
        {
            DodgeVec = moveVec;
            speed *= 2f;
            anim.SetTrigger("doDodge");
            
            isDodge = true;

            Invoke("DodgeOut", 0.4f); //�ð��� �Լ� ȣ��
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
