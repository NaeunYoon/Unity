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
        //���鼱������ : �������� �׸��� �̵�
        transform.position =
            Vector3.Slerp(transform.position, target, 0.005f);

        //�� Slerp�� ������ ��� ���ϳ���..
    }
}
