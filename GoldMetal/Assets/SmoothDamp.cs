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
        //SmoothDamp(������ġ, ��ǥ��ġ, �����ӵ�, �ӵ�)
        //������ �Ű������� �ݺ���Ͽ� �ӵ� ����
        //������ �ӵ��� ���ٰ� �ε巴�� ��ǥ ������ �����ϴ� ����
        //ref : �������� -> �ǽð����� �ٲ�� �� ���� ����

        Vector3 velo = Vector3.zero;

        //Vector3 velo = Vector3.up*50f;

        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
    }
}
