using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slerp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Vector3 target = new Vector3(8, 1.5f, 0);
    // Update is called once per frame
    void Update()
    {
        //구면선형보간 : 포물선을 그리며 이동
        transform.position =
            Vector3.Slerp(transform.position, target, 0.005f);

        //왜 Slerp는 포물선 운동을 안하나요..
    }
}
