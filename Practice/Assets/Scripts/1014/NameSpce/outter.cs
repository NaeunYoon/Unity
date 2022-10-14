using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Study01;    //1.
                    // 다른 스크립트에서 선언된 네임스페이스를 또다른 스크립트에서 사용하기 위해
                    // using 선언해준다
                    //모노비해비어 없어도 동작함 왜냐면 유징하거나 네임스페이스 가져왔기 때문에 됨
                    //인스팩터창에 붙진 않겠지만 모노비해비어를 상속받은 다른 클래스 안에서 불러오는거 가능

public class outter : MonoBehaviour
{
    
    void Start()
    {
        Study01._NameSoceSample ns = new Study01._NameSoceSample();     //2. 클래스를 네임스페이스로 접근해서 변수를 할당해준다
                                                                        //클래스는 new로 새롭게 메모리르 할당해준다
                                                                        //변수.함수로 접근해서 다른 스크립트에 있는 네임스페이스>클래스> 함수 불러온다
        ns.Show();

        //_NameSoceSample ns = new _NameSoceSample();       //네임스페이스를 사용해서 함수를 호출하는 1번 방법
        //ns.Show();                                         using이 되어 있으니 바로 클래스를 호출해주고 변수를 할당해준다
                                                            //할당된 변수는 힙에 저장된 메모리의 주소값을 가르킨다
                                                             // new 로 힙 메모리에 할당해준다
                                                             //클래스
    }

    
    void Update()
    {
        
    }
}
