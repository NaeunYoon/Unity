using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    void Update()
    {
        //Vector3 : Ŭ�������� �����ϴ� �̵��Լ�

        //1---------------------------------------------------------------------------
        //MoveTowards : ����̵�
        //MoveTowards(������ġ, ��ǥ��ġ, �ð�)
        //������ �Ű������� ����Ͽ� �ӵ� ����
        //������ �ӵ��� ��
        transform.position = Vector3.MoveTowards(transform.position,target,2f);
    }
}
