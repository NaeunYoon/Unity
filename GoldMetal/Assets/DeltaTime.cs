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
        //Time.deltaTime �����
        //Time.deltaTime : ���� �������� �Ϸ���� �ɸ� �ð�
        //10 ������ : ������Ʈ�� 10��, 60������ : ������Ʈ�� 60��
        //���� �����ε� ��ǻ�Ϳ� ���� ������Ʈ �ӵ��� �޶����� ���� �ӵ�/�ֱⰡ �޶����� ������
        //deltaTime ���� �������� ������ ũ��, �������� ������ ����

        //1. Translate : ���Ϳ� ���ϱ�
                                            // transform.Translate(Vec * Time.deltaTime)
        //2. Vector �Լ� : �ð� �Ű������� ���ϱ�
                                            // Vector3.Lerp(Vec1,Vec2,T * Time.deltaTime)



    }
}
