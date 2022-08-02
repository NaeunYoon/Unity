using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI 관련 라이브러리
using UnityEngine.SceneManagement; //Scene관련 라이브러리
using TMPro;//textMeshPro 에 접근 가능

public class GameManager : MonoBehaviour
{

    public GameObject gameoverText; //게임 오버 시 활성화할 텍스트 게임 오브젝트

    public TextMeshProUGUI timeText; //생존 시간을 표시할 텍스트 컴포넌트

    public TextMeshProUGUI recordText; //최고 기록을 표시할 텍스트 컴포넌트

    private float surviveTime; //생존 시간 ( 게임 시작 이후 현재까지 플레이어가 살아남은 시간)
    private bool isGameOver; //게임오버 상태 (게임오버 상태를 표현)

    // Start is called before the first frame update
    void Start()
    {
        //생존시간과 게임오버 상태 초기화
        surviveTime = 0f;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            surviveTime +=Time.deltaTime; //생존시간 갱신
            timeText.text = "Time :" + (int)surviveTime; //갱신한 생존시간을 timeText 컴포넌트를 이용해 표시
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R)) //게임오버 상태에서 R키를 누른 경우
            {
                SceneManager.LoadScene("SampleScene"); // SampleScene을 로드
            }
        }
    }
    public void EndGame() //현재 게임을 게임오버 상태로 변경하는 메서드
    {
        isGameOver = true; // 현재 상태를 게임오버 상태로 전환
        gameoverText.SetActive(true); //게임오버 텍스트 게임 오브젝트를 활성화


        float bestTime = PlayerPrefs.GetFloat("BestTime"); //BestTime 키로 저장된 이전까지의 최고기록 가져오기
        if(surviveTime > bestTime) //이전까지의 최고 기록보다 현재 생존 시간이 더 크다면
        {
            bestTime = surviveTime; //최고 기록 값을 현재 생존 시간 값으로 변경
            PlayerPrefs.SetFloat("BestTime",bestTime); // 변경된 최고 기록을 BestTime 키로 저장
        }
        recordText.text = "Best Time " + (int)bestTime; //최고 기록을 recordText 텍스트 컴포넌트를 이용해 표시
    }
}
