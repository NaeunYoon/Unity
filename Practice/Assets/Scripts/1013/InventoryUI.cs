using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel; //inventoryUI오브젝트를 담을 판넬
    bool activeInventory =false;
    
    void Start()
    {
        inventoryPanel.SetActive(activeInventory);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;     //activeInventory 반전
            inventoryPanel.gameObject.SetActive(activeInventory); //활성 비활성화
        }
    }
}
