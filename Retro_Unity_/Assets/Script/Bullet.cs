using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed=8f; //탄알 이동 속력
    private Rigidbody bulletRigidbody; //이동에 사용할 리지드바디 컴포넌트(중력사용 해제)
    //콜라이더 설정 : 총알이 다른 탄알에 충돌했을 때 튕겨나가지 않고 그냥 통과하도록 Trigger 체크

    // Start is called before the first frame update
    void Start()
    {
        //Bullet 스크립트가 활성화 될 때, Bullet Rigidbody 컴포넌트에 할당
        bulletRigidbody = GetComponent<Rigidbody>();
        //리지드바디의 속도 = 앞쪽방향 * 이동속력
        bulletRigidbody.velocity = transform.forward*speed;
        //앞쪽 방향에 이동속력을 곱해서 게임 오브젝트의 앞쪽 방향(z축)으로 speed 만큼의 속도를 표현한 값
        //transform.forward 는 Vector3타입의 변수
        //transform 컴포넌트는 게임 오브젝트의 위치 크기 회전을 담당하는 컴포넌트


        //3초 뒤에 게임오브젝트 파괴
        //Destroy(gameObject, obj) : 오브젝트 이름
        //Destroy(gameObject obj,float t) : 오브젝트 이름, 시간
        Destroy(gameObject,3f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) //other 는 충동한 상대 게임 오브젝트의 콜라이더 컴포넌트
    {
        //충돌한 상대 오브젝트가 player 태그를 가진 경우
        if (other.tag == "Player")
        {
            //상대방 게임 오브젝트에서 PlayerController 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();

            //상대방으로부터 PlayerController 컴포넌트를 가져오는 데 성공했다면
            if (playerController != null)
            {       //상대방 PlayerController 컴포넌트의 Die 메서드 실행 
                    playerController.Die();
            }
        }



    }

}
