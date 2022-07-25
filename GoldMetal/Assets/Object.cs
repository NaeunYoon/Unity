using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Tranform : 오브젝트 형태에 대한 기본 컴포넌트, 오브젝트와 트랜스폼은 1:1 관계 (위치 회전 크기) , 하나의 클래스

        //트랜스폼은 선언해서 초기화 할 필요가 없음 Transform tr; 유니티가 알아서 만들어놓음

        //오브젝트는 변수 transform을 항상 가지고 있음

        //클래스 이름은 대문자 Transform 변수 이름은 소문자 transform

        //컴포넌트는 마우스 우측 버튼으로 리셋 가능

        //Translate : 벡터 값을 현재 위치에 더하는 함수


        //int num = 4; 와 같은 단순한 값을 수학계에서는 스칼라 값이라고 부름
        //단순한 값에 방향값이 주어지면 그것이 벡터이다
        //벡터 : 방향과그에 대한 크기 값

       Vector3 vec = new Vector3(5,0,0);
        //벡터값 변수 뉴 벡터 (x,y,z);   //2차원은 2개만 넣으면 됨
        //방향과 크기를 모두 가지고 있기 때문에 벡터값이라고 한다.
        //일반 변수와 다르게 new를 사용해야함
        //Translate를 쓰기 위해서는 vector3를 넣어야 함

        transform.Translate(vec);
        //x축 값으로 5만큼 감
        //Translate는 말 그대로 이동한다는 의미임 = 얼만큼 이동을 하느냐
        //vec의 크기만큼 이동을 하기 때문에 000일 때는 이동을 하지 않음 (위치에 더하기를 함)





    }

    // Update is called once per frame
    void Update()
    {

        //1초에 60회씩 동작함

        //Vector3 vec = new Vector3(0.01f, 0, 0);
        //transform.Translate(vec);

        //메인카메라에 스크립트를 넣으면 오브젝트랑 카메라가 같이 올라감

        //--------------------------------방향키 사용해서 이동

        //중간값 있는 ver
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);

        //중간 값 없는 ver

        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        //transform.Translate(vec);

    }
}
