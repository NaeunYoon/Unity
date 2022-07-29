using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Animal
{
    //동물에 대한 변수
    public string name;
    public string sound;

    //울음소리를 저장하는 메서드
    public void Playsound()
    {
        Debug.Log(name + ":" + sound);
    }
    
    
}
