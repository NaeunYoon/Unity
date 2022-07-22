using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string title2 = "전설의";
    string playerName2 = "용사";
    int health2 = 30;
    int level2 = 5;
    float strength2 = 15.5f;
    int exp2 = 1500;
    int mana2 = 25;
    bool isFullLevel2=false;


    int health = 30; //전역변수 : 함수 바깥에 선언된 변수
    //용사의 필수 데이터를 담은 것은 전역변수

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");

        //--------변수의 종류( 이름을 넣는 것을 선언, 값을 넣는 것을 초기화 라고 함
        //정수형
        int level = 5;
        //실수형, 끝에 꼭 f 붙이기
        float strength=15.5f;
        //문자
        string playerName = "윤나은";
        //논리형(참,거짓)
        bool isFullLevel=false;

        //--------그룹형 변수(1)
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        //--------그룹형 변수(2)
        int[] monsterLevel = new int[3];
        
        monsterLevel[0] = 1;
        monsterLevel[1] = 5;
        monsterLevel[2] = 30;


        //--------리스트

        List<string> items = new List<string>();
        //꺽쇠 괄호 안에다가 자료형 타입을 넣어줘야 한다 generic 이라고 한다
        items.Add("생명물약30");
        items.Add("마나물약30");
        items.RemoveAt(0);

        List<int> transform=new List<int>();
        transform.Add(1);
        //크기를 벗어난 탐색은 오류를 발생 (인덱스 오류)

        //--------연산자 ( 상수 변수 값을 연산해주는 기호)
        int exp=1500;
        exp = 1500 + 320; //더하기
        exp = exp - 10; //뺴기
        level = exp / 300; //나누기
        strength = level * 3.1f; //곱하기(힘은 레벨에 비례해서 3.1만큼 증가한다)
        int nextEXP = 300 - (exp % 300); //나머지 연산자 

        //--------문자열
        string title = "전설의";

        //--------비교연산자(>,<,>=,<=)
        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        bool isEndTutorial = level > 10;

        //--------논리연산자(&& 두 값이 모두 true일 때 출력)
        int health = 30;
        int mana = 15;
        //bool isBadCondition = health <= 50 && mana <= 20;

        //--------논리연산자(|| 두 값 중 하나만 true이면 true 출력)
        bool isBadCondition = health <= 50 || mana <= 20;

        //--------논리연산자(?A:B: TRUE일 때 A, FALSE일 때 B 출력)
        string condition = isBadCondition ? "나쁨" : "좋음";

        //--------키워드(프로그래밍 언어를 구성하는 특별한 의마가 담긴 단어)
        //변수 이름이나 값으로 사용할 수 없음

        //--------조건문
        //if 조건이true일 때, 로직 실행
        //else 앞의 if가 실행되지 않으면 실행

        //--------switch,case : 변수의 값에 따라 로직 실행
        //default : 모든 case를 통과한 후 실행
        //cese끼리 같이 묶으면 같은 로직을 수행한다

        //--------반복문 ( 조건에 만족하면 로직을 반복하는 제어문)
        //while : 조건이 true 일 때 로직이 실행
        //for : 변수를 연산하면서 로직 반복 실행

        //--------변수 길이
        //.Length (배열)
        //.Count (리스트)

        //--------foreach : for의 그룹현 변수 탐색 특화
        //직접 그룹형 변수 안에 있는 아이템을 하나씩 끄집어내서 중괄호 안에서 직접 사용

        //함수 : 여러가지 기능을 편리하게 사용하도록 구성된 영역

        //클래스 : 하나의 사물(오브젝트)와 대응하는 로직
        //클래스 : 클래스 선언에 사용
        Player player = new Player();

        player.id = 0;
        player.name = "윤나은";
        player.title = "졸린";
        player.strength = 2.4f;
        player.weapon = "망치";
       

        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은"+ player.level+"입니다");
        Debug.Log(player.move());



        //타입 대신에 클래스 이름 / 변수 명/ = / new class():
        //이 클래스를 하나의 변수로 만들게 됨 ( 인스턴스 : 정의된 클래스를 변수 초기화로 실체화
        //접근자 문제 



        //프로그래밍은 선언-초기화-호출(사용) 순서로 함

        //변수
        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);
        //배열
        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        Debug.Log("맵에 존재하는 몬스터 레벨은?");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);
        //리스트 (배열과는 다르게 안에 있는 데이터 삭제가 가능)
        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        //연산자
        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextEXP);
        Debug.Log("용사의 이름은?");
        Debug.Log(title+" "+playerName);
        //비교연산자
        Debug.Log("용사는 만렙입니까?"+" "+ isFullLevel);
        Debug.Log("튜토리얼이 끝난 용사입니까?" + " " + isEndTutorial);
        //논리연산자
        Debug.Log("용사의 상태가 나쁩니까?" + " " + isBadCondition);
        Debug.Log("용사의 상태가 나쁩니까?" + " " + condition);
        //if 조건문
        if (condition == "나쁨")
        {
            Debug.Log("용사의 상태가 나쁘니 아이템을 사용하세요");
        }
        else
        {
            Debug.Log("플레이어의 상태가 좋습니다");
        }

        if (isBadCondition && items[0]=="생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명물약을 사용하였습니다");
        }
        else if(isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나물약을 사용하였습니다");
        }

        //switch,case

        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현");
                break;
            default:
                Debug.Log("??? 몬스터가 출현");
                break;
                    
        }
        //반복문 while
        while (health > 0)
        {
            health--;
            if (health > 0)
            {

                Debug.Log("독 데미지를 입었습니다" + " " + health);
            }
            else
            {
                Debug.Log("사망하였습니다");
            }
            if(health == 10)
            {
                Debug.Log("해독제를 사용합니다");
                break ;
            }
        }
        //for문
        for(int count=0; count<10; count++)
        {
            health++;
                Debug.Log("붕대치료중.."+" "+health);
        }
        //그룹형 변수 길이
        for (int index = 0; index < monsters.Length; index++)
        {
            
            Debug.Log("이 지역에 있는 몬스터.." + " " + monsters[index]);
        }
        //foreach

        foreach(string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + " " + monster);
        }

        health = Heal(health);
        //매개변수를 갖고 있음
        Heal2();

        for(int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는" + monsters[index] + " 에게" + Battle(monsterLevel[index]));
        }


    }

    //함수
    //함수 이름 앞에 함수가 반환하는 자료형을 써야하고, 괄호 안에는 이 함수가 받을 변수를 적음
    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("힐을 받았습니다" + " " + currentHealth);
        return currentHealth;
        //함수가 값을 반환할 때 사용 ( 함수 앞에 반환하는 타입이 있을 때 사용)
        //20에서 10 받아서 30 출력
    }
    //반환 데이터가 없는 함수타입
    void Heal2()
    {
        health += 10;
        Debug.Log("힐을 받았습니다" + " " + health);
        
    }
    //지역변수 : 함수 안에서 선언된 변수
    //전역변수 : 함수 밖에서 선언된 변수

    string Battle(int monsterLevel)
    {
        string result;
        if (level2 >= monsterLevel)
        {
            result = "이겼습니다";
        }
        else
        {
            result = "졌습니다";

            
        }
    return result;
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
