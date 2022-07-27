using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDamp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Vector3 target = new Vector3(8, 1.5f, 0);
    // Update is called once per frame
    void Update()
    {
        //2---------------------------------------------------------------------------
        //SmoothDamp
        //SmoothDamp(현재위치, 목표위치, 참조속도, 속도)
        //마지막 매개변수에 반비례하여 속도 증가
        //일정한 속도로 가다가 부드럽게 목표 지점에 착륙하는 느낌
        //ref : 참조접근 -> 실시간으로 바뀌는 값 적용 가능

        Vector3 velo = Vector3.zero;

        //Vector3 velo = Vector3.up*50f;

        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
    }
}
