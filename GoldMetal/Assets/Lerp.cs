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
        //Lerp : ��������, SmoothDamp���� ���ӽð��� ��
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);
        //������ �Ű������� ����Ͽ� �ӵ� ����
        //���� ���� �� ���� ������ ����
    }
}
