using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    // Start is called before the first frame update
  
    Vector3 target = new Vector3(8, 1.5f, 0);

    // Update is called once per frame
    void Update()
    {
        //3---------------------------------------------------------------------------
        //Lerp : 선형보간, SmoothDamp보다 감속시간이 김
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);
        //마지막 매개변수에 비례하여 속도 증가
        //값을 적게 줄 수록 느리게 간다
    }
}
