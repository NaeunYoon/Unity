using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Vector3 target = new Vector3(8, 1.5f, 0);
    // Update is called once per frame
    void Update()
    {
        //Vector3 : 클래스에서 제공하는 이동함수

        //1---------------------------------------------------------------------------
        //MoveTowards : 등속이동
        //MoveTowards(현재위치, 목표위치, 시간)
        //마지막 매개변수에 비례하여 속도 증가
        //일정한 속도로 감
        transform.position = Vector3.MoveTowards(transform.position,target,2f);

        

     


    }
}
