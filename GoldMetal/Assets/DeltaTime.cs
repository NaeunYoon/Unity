using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime 사용방법
        //Time.deltaTime : 이전 프레임의 완료까지 걸린 시간
        //10 프레임 : 업데이트가 10번, 60프레임 : 업데이트가 60번
        //같은 게임인데 컴퓨터에 따라 업데이트 속도가 달라지고 실행 속도/주기가 달라지기 떄문에
        //deltaTime 값은 프레임이 적으면 크고, 프레임이 많으면 작음

        //1. Translate : 벡터에 곱하기
                                            // transform.Translate(Vec * Time.deltaTime)
        //2. Vector 함수 : 시간 매개변수에 곱하기
                                            // Vector3.Lerp(Vec1,Vec2,T * Time.deltaTime)



    }
}
