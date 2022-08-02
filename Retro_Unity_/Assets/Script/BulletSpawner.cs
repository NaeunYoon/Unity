using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; //������ ź���� ���� ������ (ź���� �����ϴ� �� ���)
    public float spawnRateMin = 0.5f; //�ּ� ���� �ֱ� (�� ź���� �����ϴ� �� �ɸ��� �ð��� �ּڰ�)
    public float spawnRateMax = 3f; //�ִ� ���� �ֱ� (�� ź���� �����ϴ� �� �ɸ��� �ð��� �ִ�)


    private Transform target; //�߻��� ��� (������ ��� ���� ������Ʈ�� Ʈ������ ������Ʈ)
    private float spawnRate; //���� �ֱ� (���� ź���� ������ ������ ��ٸ� �ð�(spawnRateMin��spawnRateMax�� ������)
    private float timeAfterSpawn; //�ֱ� ���� �������� ���� �ð� (������ ź�� ���� �������� �帥 �ð��� ǥ���ϴ� Ÿ�̸�)



    // Start is called before the first frame update
    void Start()
    {   //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        //ź�� ���� ������ spawnRateMin��spawnRateMax�� ���������� ����
        //Random.Range(�ּڰ�, �ִ�)

        //Random.Range(0, 3) : 0,1,2�߿� �ϳ��� int ������ ���
        //Random.Range(0f, 3f) : 0f,1f,2f,3f ������ float���� ���(�� : 0.5f)

        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        //PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<PlayerController>().transform;
        //���� �ڵ�� ���� �� 2�ٷ� ǥ���� ��
        //PlayerController playerController2 = FindObjectOfType<PlayerController>();
        //target = playerController2.transform;

    }

    // Update is called once per frame
    void Update()
    {   

        //timeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;
        //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ��ٸ�?
        if (timeAfterSpawn >= spawnRate)
        {   //������ �ð��� ����
            timeAfterSpawn = 0;
        
        //bulletPrefab �������� transform.position�� transform.rotation ȸ������ ����
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //������ bullet ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��
        bullet.transform.LookAt(target);
        //������ ���� ������ spawnRateMin, spawnRateMax ���̿��� ���� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
