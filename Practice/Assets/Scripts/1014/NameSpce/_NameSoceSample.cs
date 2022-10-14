using UnityEngine;
/*
 네임스페이스가 포함하고 있는 것

1. 네임스페이스
2. 클래스
3. 구조체
4. 인터페이스
 
 */

namespace Study01
{
    namespace Study02
    {
        public class Test02
        {

        }
    }

    public class _NameSoceSample    //모노비헤비어가 있으면 인스팩터창에 붙고,
                                    //없어도 네임스페이스 통해서 다른 스크립트에서 사용 가능
    {
        public int num1 = 10;

        public void Show()
        {
            Debug.Log("스터디 시작");
        }
    }
    public class Test01
    {
        public int num2;
    }

    struct SampleStruct
    {
        public string Name;
    }

    interface Istudy
    {
        void IstudyStart();
    }


}

