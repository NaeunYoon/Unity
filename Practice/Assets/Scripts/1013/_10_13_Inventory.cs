using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.EventSystems;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class _10_13_Inventory : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public List<_10_13_Slot> slotList;     //������Ʈ Ÿ������ ����Ʈ�� ����
    public Image selectedIcon;      //������ ������ �̵��ϴ� ������
    private int selectedSlotIndex;       //������ ������ ����Ʈ �ε���
    private void Awake()
    {
        selectedSlotIndex = 0;
        //slotList = new List<_10_13_Slot>();


    }
    void Start()
    {
        selectedIcon.gameObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData _eventData)
    {

        //foreach(_10_13_Slot one in slotList)
        for (int i = 0; i < slotList.Count; i++)
        {
            if (slotList[i].isInRect(_eventData.position))
            {
                selectedSlotIndex = i;
                selectedIcon.sprite = Resources.Load<Sprite>("Icons/" + slotList[i].uiIcon.sprite.name);   //���ҽ��̸� (�ε��ؼ� ����)
                selectedIcon.rectTransform.position = _eventData.position;
                selectedIcon.gameObject.SetActive(true);
                Debug.Log("���ý���" + slotList[i].gameObject.name);     //������ ����
            }
        }
    }

    public void OnDrag(PointerEventData _eventData) //�ݺ��� �� �巡�װ� ���⋚���� ���!
    {
        if (selectedSlotIndex != -1)
        {
            selectedIcon.rectTransform.position = _eventData.position;
        }
    }

    //public void OnEndDrag(PointerEventData _eventData)//�巡�� ������ �� ����
    //{
    //    if(selectedSlotIndex == -1)
    //    {
    //        return;
    //    }

    //    int tmpSelectedIcon = -1;

    //    for (int i = 0; i < slotList.Count; i++)
    //    {
    //        if (slotList[i].isInRect(_eventData.position))
    //        {
    //            tmpSelectedIcon = i;
    //            break;
    //        }
    //    }
    //}

    public void OnPointerUp(PointerEventData _eventData) // ��� ���Կ��� �´��� ã��
    {
        if (selectedSlotIndex == -1 )  //����ִ� ������ ��� �Ʒ��� �ڵ带 �������� �ʾƵ� �ȴ�
        {
           return;  
        }

      

        //selectedIcon.gameObject.SetActive(false);


        int tmpIconIndex = -1;

        for (int i = 0; i < slotList.Count; i++)   //���� ��ġ��!
        {
            if (slotList[i].isInRect(_eventData.position))
            {
                tmpIconIndex = i;
                break;
            }
        }

        // tmpIconIndex ���� -1�� �ƴ� ��� ������ �̹����� ��ü�Ѵ�
        // selectedIconIndex�� slotList�� uiimage�� �ٲ۴�
        // 

        if(tmpIconIndex != -1)
        {
            Sprite tmp = selectedIcon.sprite;
            slotList[selectedSlotIndex].uiIcon.sprite = slotList[tmpIconIndex].uiIcon.sprite;
            slotList[tmpIconIndex].uiIcon.sprite = tmp;
            selectedIcon.gameObject.SetActive(false);
        }





        /*
         * 
         * 
         * 
         1. selectedIcon�� slotList[2]�� ��
         2. ���� �ִ� slotList[1]�� �����
         3. slotList[2]�� �ִ� �������� slotList[1]�� ��
         
         */


    }
}
