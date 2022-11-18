using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisExample : MonoBehaviour
{
    private static ThisExample _instance;




    void Start()
    {
        //Debug.Log(this.gameObject.name); //큐브 나를 두번 놀린 큐브
        //Destroy(this);


        if(_instance == null)
        {
            _instance = this;
        }

    }


    void Update()
    {
        
    }
}
