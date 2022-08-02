using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController02 : MonoBehaviour
{
    public  Rigidbody playerRigedbody; //이동에 사용할 Rigedbody 컴포넌트
    //오뚜기가 넘어지지 않도록 설정했음
    //Public 으로 설정하면 에디터 창에서 직접 drag & drop 할 필요가 없음

    public float speed=8f; //이동 속력

    // Start is called before the first frame update
    void Start()
    {
        //게임 오브젝트에서 Rigedbody 컴포넌트를 찾아 playerRigedbody에 할당 => public을 private로 바꿔주기
        //왜냐면 이미 Start 함수에서 할당했음 ㅇㅇ, 유니티 에디터에서 직접 못넣음
        playerRigedbody = GetComponent<Rigidbody>();

        //꺽쇠<>는 제네릭기법임. 원하는 타입을 명시하면 클래스나 메서드가 해당 타입에 맞춰 동작함
        


    }

    // Update is called once per frame
    void Update()
    {
        //-----------------------------------------------------1번방법: 물리적인 힘을 가하기(AddForce)
        // Input : 사용자 입력을 감지하는 함수
        // Input.GetKey(Keycode key) : 키보드의 식별자를 Keycode로 입력받음,
        // 해당 키가 눌리고 있으면 True, 아니면False 

        //위쪽 방향키 입력이 감지된 경우, z 방향으로 힘주기
        if (Input.GetKey(KeyCode.UpArrow)==true)
        {
            playerRigedbody.AddForce(0f,0f,speed);
        }
        //아래쪽 방향키 입력이 감지된 경우, -z 방향으로 힘주기
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigedbody.AddForce(0f, 0f, -speed);
        }
        //오른쪽 방향키 입력이 감지된 경우, x 방향으로 힘주기
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigedbody.AddForce(speed, 0f, 0f);
        }
        //왼쪽 방향키 입력이 감지된 경우, -x 방향으로 힘주기
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigedbody.AddForce(-speed, 0f, 0f);
        }

        

        //=관성이 적용되어 무게감이 느껴짐
        //AddForce는 힘을 추가한다. 누적된 힘으로 속도를 점진적으로 증가시키기 때문에,
        //속도가 빨라지기까지 시간이 걸린다. 이동중에 방향을 바꾸는 경우, 관성에 의해 힘이 상쇄
        //=방향전환이 느림

    }

    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        // gameobject 를 통해 오브젝트에 접근
        // 접근한 gameobject의 false를 실행
        gameObject.SetActive(false);
    }

}
