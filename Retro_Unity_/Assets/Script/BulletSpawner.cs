using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; //생성한 탄알의 원본 프리팹 (탄알을 생성하는 데 사용)
    public float spawnRateMin = 0.5f; //최소 생성 주기 (새 탄알을 생성하는 데 걸리는 시간의 최솟값)
    public float spawnRateMax = 3f; //최대 생성 주기 (새 탄알을 생성하는 데 걸리는 시간의 최댓값)


    private Transform target; //발사할 대상 (조준할 대상 게임 오브젝트의 트랜스폰 컴포넌트)
    private float spawnRate; //생성 주기 (다음 탄알을 생성할 때까지 기다릴 시간(spawnRateMin과spawnRateMax의 랜덤값)
    private float timeAfterSpawn; //최근 생성 시점에서 지난 시간 (마지막 탄알 생성 시점부터 흐른 시간을 표시하는 타이머)



    // Start is called before the first frame update
    void Start()
    {   //최근 생성 이후의 누적 시간을 0으로 초기화
        timeAfterSpawn = 0f;
        //탄알 생성 간격을 spawnRateMin과spawnRateMax의 랜덤값으로 지정
        //Random.Range(최솟값, 최댓값)

        //Random.Range(0, 3) : 0,1,2중에 하나가 int 값으로 출력
        //Random.Range(0f, 3f) : 0f,1f,2f,3f 사이의 float값이 출력(예 : 0.5f)

        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        //PlayerController 컴포넌트를 가진 게임 오브젝트를 찾아 조준 대상으로 설정
        target = FindObjectOfType<PlayerController>().transform;
        //위에 코드랑 같은 걸 2줄로 표현한 것
        //PlayerController playerController2 = FindObjectOfType<PlayerController>();
        //target = playerController2.transform;

    }

    // Update is called once per frame
    void Update()
    {   

        //timeAfterSpawn 갱신
        timeAfterSpawn += Time.deltaTime;
        //최근 생성 시점에서부터 누적된 시간이 생성 주기보다 길다면?
        if (timeAfterSpawn >= spawnRate)
        {   //누적된 시간을 리셋
            timeAfterSpawn = 0;
        
        //bulletPrefab 복제본을 transform.position과 transform.rotation 회전으로 생성
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //생성된 bullet 오브젝트의 정면 방향이 target을 향하도록 회전
        bullet.transform.LookAt(target);
        //다음번 생성 간격을 spawnRateMin, spawnRateMax 사이에서 랜덤 지정
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
