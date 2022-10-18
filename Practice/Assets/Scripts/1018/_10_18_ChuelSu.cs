using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


 class _10_18_ChuelSu : MonoBehaviour
{

    private class Cheulsu
    {
        string name;
        int age;
        string address;
        int weight;
        int height;

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public int AGE
        {
            get { return age; }
            set { age = value; }
        }
        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }
        public int WEIGHT
        {
            get { return weight; }
            set { weight = value; }
        }
        public int HEIGHT
        {
            get { return height; }
            set { height = value; }
        }

    }
    void Start()
    {
        Cheulsu chuelsu = new Cheulsu();


        chuelsu.NAME = "捞抚";
        Debug.Log(chuelsu.NAME);
        //chuelsu.name = "捞抚";
        //Debug.Log(chuelsu.name);

        chuelsu.AGE = 1;
        Debug.Log(chuelsu.AGE);
        //chuelsu.age = 1;
        //Debug.Log(chuelsu.age);
        
        chuelsu.ADDRESS = "林家";
        Debug.Log(chuelsu.ADDRESS);
        //chuelsu.address = "林家";
        //Debug.Log(chuelsu.address);

        chuelsu.WEIGHT = 1;
        Debug.Log(chuelsu.WEIGHT);
        //chuelsu.weight = 1;
        //Debug.Log(chuelsu.weight);

        chuelsu.HEIGHT = 20;
        Debug.Log(chuelsu.HEIGHT);
        //chuelsu.height = 20;
        //Debug.Log(chuelsu.height);




    }

   
    void Update()
    {
        
    }
}
