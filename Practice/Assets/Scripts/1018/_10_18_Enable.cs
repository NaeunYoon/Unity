using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_18_Enable : MonoBehaviour
{
    /**
     * Awake -> Onenable -> Start -> Update -> Ondisable
     * 
     */

    private void Awake()
    {
        Debug.Log("Awake");
    }
    void Start()
    {
        Debug.Log("Start");
    }
    void Update()
    {
        Debug.Log("Update");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    private void OnDisable()
    {
        Debug.Log("Ondisable");
    }

}
