using UnityEngine;

// 플레이어 캐릭터를 사용자 입력에 따라 움직이는 스크립트
public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 5f; // 앞뒤 움직임의 속도
    public float rotateSpeed = 180f; // 좌우 회전 속도


    private PlayerInput playerInput; // 플레이어 입력을 알려주는 컴포넌트
    private Rigidbody playerRigidbody; // 플레이어 캐릭터의 리지드바디
    private Animator playerAnimator; // 플레이어 캐릭터의 애니메이터

    private void Start() {
        // 사용할 컴포넌트들의 참조를 가져오기
        // 처음 시작할 때 한번 시작하므로 컴포넌트들을 자동으로 할당한다

        playerInput=GetComponent<PlayerInput>();
        playerRigidbody=GetComponent<Rigidbody>();
        playerAnimator=GetComponent<Animator>();
    }

    // FixedUpdate는 물리 갱신 주기에 맞춰 실행됨
    private void FixedUpdate() {
        // 물리 갱신 주기마다 움직임, 회전, 애니메이션 처리 실행
        //Update에서 실행하지 않고 Fixed Update에서 실행하는 이유 : 물리 정보 갱신 주기 0.2초 에 맞춰 실행되기 때문에 오차 확률이 줄어든다

        //움직임 실행
        Move();
        //회전 실행
        Rotate();

        //입력값에 따라 애니메이터의 Move 파라미터 값 변경
        playerAnimator.SetFloat("Move", playerInput.move);
    }

    // 입력값에 따라 캐릭터를 앞뒤로 움직임
    private void Move() {
        //상대적으로 이동 할 거리 계산
        Vector3 moveDistance = playerInput.move * transform.forward * moveSpeed * Time.deltaTime;

        //=> 캐릭터가 앞쪽 방향으로 이동한다고 가정할 떄, 이동할 거리와 방향은 
        //앞쪽방향 *속력*시간 이다
        //계산된 이동 거리에 사용자 입력갑을 곱한다
        //플레이어 입력이 없다면 0이므로 최종 계산된 move는 0으로 음직이지 않는다



        //리지드바디를 이용해 게임 오브젝트 위치 변경
        playerRigidbody.MovePosition(playerRigidbody.position + moveDistance);
        //MovePosition 함수는 전역 위치를 사용한다
        //예를 들어 0,0,3 이동이면 현재 위치 기준이 아닌 전역좌표 0,0,3으로 이동한다는 뜻이다
        //따라서 현재위치 + 상대적으로 이동할 거리를 구현하기 위해 playerRigidbody.position + moveDistance 를 입력한다

        //이동을 구현하는 두번째 방법
        //transform.position = transform.position + move;
        //하지만 이렇게 하지 않은 이유는 트랜스폼의 위치값을 변경하면 물리처리를 무시하고 위치를 덮어씀 (벽을 무시하고 벽 반대쪽으로 순간이동함)





    }

    // 입력값에 따라 캐릭터를 좌우로 회전
    private void Rotate() {

        //상대적으로 회전할 수치 계산
        float turn = playerInput.rotate * rotateSpeed * Time.deltaTime;
        //turn : 사용자 입력에 따라 한 프레임 동안 회전할 각도를 저장하는 변수
        //turn : 사용자입력 * 회전속도 * 시간
        
        playerRigidbody.rotation = playerRigidbody.rotation * Quaternion.Euler(0, turn, 0f);

        //현재 회전에서 turn 만큼 y축 기준으로 더 회전 

        //어떤 회전 상태에서 상대적으로 더 회전할 떄는 쿼터니언 곱 사용
        //즉 현재 회전에서 (0,turn,0)만큼 더 회전한 상태를 나타내는 쿼터니언

        //똑같이 transform.rotation이 아닌 playerRigidbody.rotation에 할당한 이유는  물리처리를 무시하고 회전하는 것을 방지하기 위함이다.


    }
}