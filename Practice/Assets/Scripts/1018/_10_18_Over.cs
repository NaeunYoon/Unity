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
    // �����ε� : �̸��� ������ �Ķ������ ���� �� Ÿ���� �ٸ���
    //�������̵� : �ڽ�Ŭ������ �θ�Ŭ������ �������ϴ� ��
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
