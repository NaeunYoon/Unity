using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel; //inventoryUI������Ʈ�� ���� �ǳ�
    bool activeInventory =false;
    
    void Start()
    {
        inventoryPanel.SetActive(activeInventory);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;     //activeInventory ����
            inventoryPanel.gameObject.SetActive(activeInventory); //Ȱ�� ��Ȱ��ȭ
        }
    }
}
