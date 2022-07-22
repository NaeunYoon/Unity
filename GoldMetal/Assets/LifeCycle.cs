using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //초기화->(활성화)->물리연산->게임로직->(비활성화)->해체

    void Awake()
    {
        //Awake : 게임 오브젝트 생성할 떄 최초 실행 ( 딱 한번만 실행 됨 )

        Debug.Log("플레이어 데이터가 준비되었습니다"); //초기화영역


    }
    private void OnEnable()
    {
        //게임 오브젝트가 활성화 되었을 때 (최초 실행이 아닌 키고 끌 때마다 실행이 된다)
        Debug.Log("플레이어가 로그인 했습니다");
    }

    // Start is called before the first frame update
    void Start()
    {
        //Start : 업데이트 시작 전, 최초 실행

        Debug.Log("사냥 장비를 챙겼습니다"); //초기화영역
    }

    void FixedUpdate()
    {
        //FixedUpdate :물리 연산 업데이트(고정된 실행 주기로CPU를 많이 사용 : CPU 부하가 많다)
        //보통 1초에 50회 호출이 된다
        Debug.Log("이동~");

    }

    // Update is called once per frame
    void Update()
    {
        //1초에 여러번 작동하는 함수 게임 로직 업데이트 ( 주기적으로 변하는 로직을 넣을 떄 사용하는 함수)
        //환경에 따라 실행 주기가 떨어질 수 있음 (FIXEDUPDATE와의 차이)
        Debug.Log("몬스터 사냥!");
        //UPDATE가 FIXED업데이트보다 상황에 따라 덜 실행/더실행 될 수 있다

    }

    private void LateUpdate()
    {
        //모든 업데이트 끝난 후 마지막으로 호출되는 함수
        //보통 캐릭터를 따라가는 카메라, 로직의 수 처리
        Debug.Log("경험치 획득");
        //업데이트랑 같은 횟수로 올라간다

    }
    private void OnDisable()
    {//게임오브젝트가 비활성화 되었을 때
        Debug.Log("플레이가 로그아웃 했습니다");
        //스크립트를 끄면 비활성화 됨
    }

    private void OnDestroy()
    {
        //게임 오브젝트가 삭제될 떄, 뭔가를 남기고 사라진다

        Debug.Log("플레이어 데이터를 해체하였습니다");
        //플레이 중에 플레이어 오브젝트를 삭제되면 실행된다
    }

}
