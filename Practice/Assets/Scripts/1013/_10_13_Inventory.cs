using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.EventSystems;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class _10_13_Inventory : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public List<_10_13_Slot> slotList;     //컴포넌트 타입으로 리스트에 보관
    public Image selectedIcon;      //선택한 슬롯의 이동하는 아이콘
    private int selectedSlotIndex;       //선택한 슬롯의 리스트 인덱스
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
                selectedIcon.sprite = Resources.Load<Sprite>("Icons/" + slotList[i].uiIcon.sprite.name);   //리소스이름 (로드해서 대입)
                selectedIcon.rectTransform.position = _eventData.position;
                selectedIcon.gameObject.SetActive(true);
                Debug.Log("선택슬롯" + slotList[i].gameObject.name);     //선택한 슬롯
            }
        }
    }

    public void OnDrag(PointerEventData _eventData) //반복함 내 드래그가 멈출떄까지 계속!
    {
        if (selectedSlotIndex != -1)
        {
            selectedIcon.rectTransform.position = _eventData.position;
        }
    }

    //public void OnEndDrag(PointerEventData _eventData)//드래그 멈췄을 때 실행
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

    public void OnPointerUp(PointerEventData _eventData) // 어느 슬롯에서 뗏는지 찾기
    {
        if (selectedSlotIndex == -1 )  //비어있는 슬롯일 경우 아래의 코드를 실행하지 않아도 된다
        {
           return;  
        }

      

        //selectedIcon.gameObject.SetActive(false);


        int tmpIconIndex = -1;

        for (int i = 0; i < slotList.Count; i++)   //슬롯 위치임!
        {
            if (slotList[i].isInRect(_eventData.position))
            {
                tmpIconIndex = i;
                break;
            }
        }

        // tmpIconIndex 값이 -1이 아닌 경우 아이템 이미지를 교체한다
        // selectedIconIndex랑 slotList의 uiimage랑 바꾼다
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
         1. selectedIcon이 slotList[2]에 들어감
         2. 원래 있던 slotList[1]이 사라짐
         3. slotList[2]에 있던 아이템이 slotList[1]에 들어감
         
         */


    }
}
