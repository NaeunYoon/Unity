using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigedbody; //이동에 사용할 Rigedbody 컴포넌트
    public float speed = 8f; //이동 속력

    // Start is called before the first frame update
    void Start()
    {
        //게임 오브젝트에서 Rigedbody 컴포넌트를 찾아 playerRigedbody에 할당 => public을 private로 바꿔주기
        //왜냐면 이미 Start 함수에서 할당했음 ㅇㅇ, 유니티 에디터에서 직접 못넣음
        playerRigedbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()


    {   //수평축과 수직축의 입력값을 저장
        //GetAxis : 어떤 축에 대한 입력값을 숫자로 반환하는 메서드
        //Input.GetAxis(string axisName) : 메서드는 축 이름을 받고 감지된 입력값을 반환 (-1 0 1) 

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동속도를 입력값과 이동 속도를 사용해 결정
        float xSpeed=xInput*speed;
        float zSpeed=zInput*speed;

        //Vector3 속도를 (xSpeed,0,xSpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed,0,zSpeed);

        //리지드바디 속도에 newVelocity 할당
        playerRigedbody.velocity = newVelocity;


        // AddForce : 힘을 누적하고 속력을 점진적으로 증가시킴
        // Velocity : 관성을 무시하고 속도가 즉시 변경

        
    }
    public void Die()
    {
        
        gameObject.SetActive(false); ////자신의 게임 오브젝트를 비활성화
        GameManager gameManager = FindObjectOfType<GameManager>();  // T씬에 존재하는 GameManager타입의 오브젝트를 찾아서 가져오기
        gameManager.EndGame(); // 가져온 GameManager 오브젝트의 Endgame()메서드 실행

    }

}
