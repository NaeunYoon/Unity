using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //������
    public enum Type
    {
        Ammo,Coin,Grende,Heart,Weapon

    };
    public Type type;
    public int value;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //������ ȸ��
       transform.Rotate(Vector3.up*10f*Time.deltaTime);
    }
}
