using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Animal tom = new Animal();
        tom.name = "��";
        tom.sound = "�߿�";

        tom.Playsound();

        //---------------------------------------------

        Animal jerry = new Animal();
        jerry.name = "����";
        jerry.sound = "����";

        jerry.Playsound();

        //---------------------------------------------
        jerry = tom;
        jerry.name = "��Ű";

        tom.Playsound();
        jerry.Playsound();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
