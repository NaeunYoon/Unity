using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //transform.Rotate(float x, float y, float z);
        transform.Rotate(0f, rotationSpeed*Time.deltaTime, 0f);
    }
}
