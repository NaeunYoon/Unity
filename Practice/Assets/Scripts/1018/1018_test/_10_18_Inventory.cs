using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.EventSystems;
using UnityEngine.EventSystems;

public class _10_18_Inventory : MonoBehaviour,IPointerDownHandler,IDragHandler,IEndDragHandler,IPointerUpHandler
{
    public List<_10_18_Slot> slotList; //에디터에 슬롯 담아주기
    int slotIndex;  //슬롯의 인덱스
    public Image selectedIcon; // 나 따라다니는 아이콘
    

    void Awake()
    {
        selectedIcon.gameObject.SetActive(false);   //시작할 때 따라다니는 아이콘 비활성화 하기
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

        for(int i = 0; i < slotList.Count; i++) //슬롯의 갯수만큼 돌리기
        {
            Debug.Log(i);
            //Debug.Log("선택한 슬롯" + slotList[i]);

            if (slotList[i].isInRect(eventData.position) && slotList[i].uiIcon.sprite != null){  //슬롯리스트의 범위가 클릭한 포지션 안에 있고 아이콘이 널이 아니면
                slotIndex = i;  //슬롯의 번호를 알기 위해 슬롯 인덱스 설정해줌
                selectedIcon.gameObject.SetActive(true);    //비활성화 한 아이콘을 활성화로 돌려줌
                selectedIcon.sprite = Resources.Load<Sprite>(slotList[i].uiIcon.sprite.name); //아이콘이름을 찾아서 똑같이 가져옴
                selectedIcon.transform.position = eventData.position;   //내 마우스를 따라다님
                Debug.Log("선택한 슬롯" + slotList[i]);
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
