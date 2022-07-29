using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Animal tom = new Animal();
        tom.name = "盆";
        tom.sound = "具克";

        tom.Playsound();

        //---------------------------------------------

        Animal jerry = new Animal();
        jerry.name = "力府";
        jerry.sound = "嘛嘛";

        jerry.Playsound();

        //---------------------------------------------
        jerry = tom;
        jerry.name = "固虐";

        tom.Playsound();
        jerry.Playsound();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
