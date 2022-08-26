using System.Collections;
using UnityEngine;

// 총을 구현한다
public class Gun : MonoBehaviour {
    // 총의 상태를 표현하는데 사용할 타입을 선언한다
    public enum State {
        Ready, // 발사 준비됨
        Empty, // 탄창이 빔
        Reloading // 재장전 중
    }

    public State state { get; private set; } // 현재 총의 상태
    //Gun 클래스 외부에서는 총의 상태를 읽을 수 있지만 총의 상태를 임의로 변경할 수 없음

    public Transform fireTransform; // 총알이 발사될 위치
    //총구의 위치와 방향을 알려주는 트렌스폼 컴포넌트. FirePosition 게임 오브젝트의 트랜스폼 컴포넌트 할당

    public ParticleSystem muzzleFlashEffect; // 총구 화염 효과
    public ParticleSystem shellEjectEffect; // 탄피 배출 효과

    private LineRenderer bulletLineRenderer; // 총알 궤적을 그리기 위한 렌더러

    private AudioSource gunAudioPlayer; // 총 소리 재생기
    public AudioClip shotClip; // 발사 소리
    public AudioClip reloadClip; // 재장전 소리

    public float damage = 25; // 공격력(탄알 한 발의 공격력)
    private float fireDistance = 50f; // 총의 최대 사정거리

    public int ammoRemain = 100; // 남은 전체 탄약
    public int magCapacity = 25; // 탄창 용량
    public int magAmmo; // 현재 탄창에 남아있는 탄약


    public float timeBetFire = 0.12f; // 총알 발사 간격(이 값을 낮추면 연사력이 올라간다)
    public float reloadTime = 1.8f; // 재장전 소요 시간
    private float lastFireTime; // 총을 마지막으로 발사한 시점(연사를 구현)


    private void Awake() {
        // 사용할 컴포넌트들의 참조를 가져오기

        gunAudioPlayer = GetComponent<AudioSource>();
        bulletLineRenderer =  GetComponent<LineRenderer>();

        bulletLineRenderer.positionCount = 2; //사용할 점을 두 개로 변경(첫번째는 총구 위치, 두번쨰는 탄알이 닿을 위치 할당)
        bulletLineRenderer.enabled = false; //라인 렌더러를 비활성화


    }

    private void OnEnable() {
        // 총 상태 초기화
        //컴포넌트가 활성화 될 때마다 매번 실행. Gun 컴포넌트가 활성화 될 때마다 총의 상태와 기본 탄알을 초기화

        //현재 탄창을 가득 채우기
        magAmmo = magCapacity;
        //총의 현재 상태를 총을 쏠 준비가 된 상태로 변경
        state = State.Ready;
        //마지막으로 총을 쏜 시점을 초기화
        lastFireTime = 0;
    }

    // 발사 시도
    public void Fire() {

        //현재 상태가 발사 가능한 상태
        //&&마지막 총 발사 시점에서 timeBetFire 이상의 시간이 지남

        //1. 첫번쨰 조건 : 총의 현재 상태가 Ready
        //2. 두번쨰 조건 : 총의 발사 간격인 timeBetFire 만큼 시간이 지나야 함 ( 현재 시간이 총을 최근에 발사한 시점 + 발사간격 이후인지 검사
        
        if(state == State.Ready && Time.time >= lastFireTime+timeBetFire)
        {
            //마지막 총 발사 시점 갱신
            lastFireTime = Time.time;
            //실제 발사 처리 진행
            Shot();
        }


    }

    // 실제 발사 처리
    private void Shot() {

        //레이캐스트에 의한 충돌 정보를 저장하는 컨테이너
        RaycastHit hit;

        //탄알이 맞은 곳을 저장할 변수
        Vector3 hitPosition = Vector3.zero;

        //레이캐스트(시작지점, 방향, 충돌정보컨테이너, 사정거리)
        if(Physics.Raycast(fireTransform.position,fireTransform.forward,out hit, fireDistance))
        {
            //f레이가 어떤 물체와 충돌한 경우

            //충돌한 상대방으로부터 Idamageable  오브젝트 가져오기 시도
            IDamageable target = hit.collider.GetComponent<IDamageable>();

            //상대방으로부터 Idamagaeble 오브젝트를 가져오는 데 성공했다면
            if(target != null)
            {
                //상대방의 InDamage 함수를 실행시켜 상대방에 데미지 주기
                target.OnDamage(damage, hit.point, hit.normal);
            }
            //레이가 충돌한 위치 저장
            hitPosition = hit.point;
        }
        else
        {
            //레이가 다른 물체와 충돌하지 않았다면
            //탄알이 최대 사정거리까지 날아갔을 때의 위치를 충돌 위치로 사용
            hitPosition = fireTransform.position + fireTransform.forward * fireDistance;
        }
        //발사이펙트 재생 시작
        StartCoroutine(ShotEffect(hitPosition));

        //남은 탄알 수를 -1
        magAmmo--;
        if(magAmmo <= 0)
        {
            //탄창에 남은 탄알이 없다면 현재 상태를 empty로 갱신
            state = State.Empty;
        }
    }

    // 발사 이펙트와 소리를 재생하고 총알 궤적을 그린다
    private IEnumerator ShotEffect(Vector3 hitPosition) {

        //총구 화염효과 재생
        muzzleFlashEffect.Play();

        //탄피배출효과재생
        shellEjectEffect.Play();

        //총격소리 재생
        gunAudioPlayer.PlayOneShot(shotClip);

        //선의 시작점은 총구의 위치
        bulletLineRenderer.SetPosition(0,fireTransform.position);

        //선의 끝점은 입력으로 들어온 충돌 위치
        bulletLineRenderer.SetPosition(1,hitPosition);

        // 라인 렌더러를 활성화하여 총알 궤적을 그린다
        bulletLineRenderer.enabled = true;

        // 0.03초 동안 잠시 처리를 대기
        yield return new WaitForSeconds(0.03f);

        // 라인 렌더러를 비활성화하여 총알 궤적을 지운다
        bulletLineRenderer.enabled = false;
    }


    // 재장전 시도
    public bool Reload() {

        if(state==State.Reloading || ammoRemain <= 0 || magAmmo >= magCapacity)
        {
            //이미 재장전 중이거나 남은 탄알이 없거나 탄창에 탄알이 이미 가득찬 경우
            return false;
        }
        //재장전처리 시작
        StartCoroutine(ReloadRoutine());
        return true;
    }

    // 실제 재장전 처리를 진행
    private IEnumerator ReloadRoutine() {
        // 현재 상태를 재장전 중 상태로 전환
        state = State.Reloading;
        
        // 재장전 소요 시간 만큼 처리를 쉬기
        yield return new WaitForSeconds(reloadTime);

        // 총의 현재 상태를 발사 준비된 상태로 변경
        state = State.Ready;
    }
}