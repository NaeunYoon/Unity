using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform target;
    public float speed;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = target.position + offset;

        //대상의 주위로 회전하는 함수(타겟 주위를)

        transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);

        offset = transform.position - target.position;

    }
}
