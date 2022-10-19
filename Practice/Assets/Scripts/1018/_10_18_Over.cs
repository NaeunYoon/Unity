using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class _10_18_Over : MonoBehaviour
{
    private void Start()
    {
        //Inherit();
    }
    // 오버로딩 : 이름이 같은데 파라미터의 갯수 및 타입이 다르면
    //오버라이딩 : 자식클래스가 부모클래스를 재정의하는 것
    public void sample()
    {

    }
    public int sample(int a)
    {
        return a;
    }
    public float sample(float a)
    {
        return a;
    }

    //---------------------------------------

    public void Inherit()
    {
        Animal ani = new Animal();
        ani.Speak();
        Dog dog = new Dog();
        Debug.Log(dog.age);
    }

}
