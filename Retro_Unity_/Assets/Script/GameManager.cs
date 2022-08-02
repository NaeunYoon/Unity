using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI ���� ���̺귯��
using UnityEngine.SceneManagement; //Scene���� ���̺귯��
using TMPro;//textMeshPro �� ���� ����

public class GameManager : MonoBehaviour
{

    public GameObject gameoverText; //���� ���� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ

    public TextMeshProUGUI timeText; //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ

    public TextMeshProUGUI recordText; //�ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime; //���� �ð� ( ���� ���� ���� ������� �÷��̾ ��Ƴ��� �ð�)
    private bool isGameOver; //���ӿ��� ���� (���ӿ��� ���¸� ǥ��)

    // Start is called before the first frame update
    void Start()
    {
        //�����ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0f;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            surviveTime +=Time.deltaTime; //�����ð� ����
            timeText.text = "Time :" + (int)surviveTime; //������ �����ð��� timeText ������Ʈ�� �̿��� ǥ��
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R)) //���ӿ��� ���¿��� RŰ�� ���� ���
            {
                SceneManager.LoadScene("SampleScene"); // SampleScene�� �ε�
            }
        }
    }
    public void EndGame() //���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    {
        isGameOver = true; // ���� ���¸� ���ӿ��� ���·� ��ȯ
        gameoverText.SetActive(true); //���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ


        float bestTime = PlayerPrefs.GetFloat("BestTime"); //BestTime Ű�� ����� ���������� �ְ��� ��������
        if(surviveTime > bestTime) //���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        {
            bestTime = surviveTime; //�ְ� ��� ���� ���� ���� �ð� ������ ����
            PlayerPrefs.SetFloat("BestTime",bestTime); // ����� �ְ� ����� BestTime Ű�� ����
        }
        recordText.text = "Best Time " + (int)bestTime; //�ְ� ����� recordText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
    }
}
