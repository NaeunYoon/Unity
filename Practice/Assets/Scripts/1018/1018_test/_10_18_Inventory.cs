using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.EventSystems;
using UnityEngine.EventSystems;

public class _10_18_Inventory : MonoBehaviour,IPointerDownHandler,IDragHandler,IEndDragHandler,IPointerUpHandler
{
    public List<_10_18_Slot> slotList; //�����Ϳ� ���� ����ֱ�
    int slotIndex;  //������ �ε���
    public Image selectedIcon; // �� ����ٴϴ� ������
    

    void Awake()
    {
        selectedIcon.gameObject.SetActive(false);   //������ �� ����ٴϴ� ������ ��Ȱ��ȭ �ϱ�
        slotIndex = -1;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");

        for(int i = 0; i < slotList.Count; i++) //������ ������ŭ ������
        {
            Debug.Log(i);
            //Debug.Log("������ ����" + slotList[i]);

            if (slotList[i].isInRect(eventData.position) && slotList[i].uiIcon.sprite != null){  //���Ը���Ʈ�� ������ Ŭ���� ������ �ȿ� �ְ� �������� ���� �ƴϸ�
                slotIndex = i;  //������ ��ȣ�� �˱� ���� ���� �ε��� ��������
                selectedIcon.gameObject.SetActive(true);    //��Ȱ��ȭ �� �������� Ȱ��ȭ�� ������
                selectedIcon.sprite = Resources.Load<Sprite>(slotList[i].uiIcon.sprite.name); //�������̸��� ã�Ƽ� �Ȱ��� ������
                selectedIcon.transform.position = eventData.position;   //�� ���콺�� ����ٴ�
                Debug.Log("������ ����" + slotList[i]);
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
    }
}
