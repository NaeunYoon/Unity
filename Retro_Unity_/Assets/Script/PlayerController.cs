using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigedbody; //이동에 사용할 Rigedbody 컴포넌트
    public float speed=8f; //이동 속력

    // Start is called before the first frame update
    void Start()
    {
        //게임 오브젝트에서 Rigedbody 컴포넌트를 찾아 playerRigedbody에 할당 => public을 private로 바꿔주기
        //왜냐면 이미 Start 함수에서 할당했음 ㅇㅇ, 유니티 에디터에서 직접 못넣음
        playerRigedbody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        //------------------------------------------------------------------1번방법

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

        //------------------------------------------------------------------2번방법




    }

    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
    }

}
