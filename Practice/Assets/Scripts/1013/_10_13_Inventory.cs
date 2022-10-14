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
        selectedSlotIndex = 0;  //선택한 슬롯의 리스트 인덱스를 0으로 초기화
        //slotList = new List<_10_13_Slot>();


    }
    void Start()
    {
        selectedIcon.gameObject.SetActive(false);   //선택한 아이콘은 게임 시작 시 보이지 않게 비할성화
    }

    public void OnPointerDown(PointerEventData _eventData)  //포인터를 눌렀을 때
    {

        //foreach(_10_13_Slot one in slotList)
        for (int i = 0; i < slotList.Count; i++)    //내가 누른 슬롯 인덱스가 나올 때까지 for문을 돌린다(중요)
        {
            if (slotList[i].isInRect(_eventData.position))  //내가 누른 슬롯차례에 슬롯 안에 마우스 포인터가 있는지 검사 후
            {
                selectedSlotIndex = i;  //선택된 슬롯 인덱스에 슬롯 리스트의 번호가 할당된다 (슬롯리스트 번호 = 선택된 슬롯 인덱스)
                selectedIcon.sprite = Resources.Load<Sprite>("Icons/" + slotList[i].uiIcon.sprite.name);   //리소스이름 (로드해서 대입)
                //내가 선택한 슬롯의 아이콘 스프라이트를 이름으로 검색해서 선택한 슬롯(빈 아이콘) 에 로드
                selectedIcon.rectTransform.position = _eventData.position;
                //내가 클릭하는 곳에 선택한 슬롯이 따라붙음
                selectedIcon.gameObject.SetActive(true);
                //슬롯이 따라붙은 후 활성화시켜준다
                Debug.Log("선택슬롯" + slotList[i].gameObject.name);     //선택한 슬롯
                //선택한 슬롯의 이름 출력
            }
        }
    }

    public void OnDrag(PointerEventData _eventData) //반복함 내 드래그가 멈출떄까지 계속!
    {
        if (selectedSlotIndex != -1)    //선택한 슬롯이 빈 슬롯이 아니라면
        {
            selectedIcon.rectTransform.position = _eventData.position;  //빈 슬롯만 아니면 내가 드래그하는 매 프레임마다 선택된 아이콘이 따라붙음
            //slotList[selectedSlotIndex].uiIcon.gameObject.SetActive(false);   //나도 옮기면 원래 있던 아이콘 없어지게 하고싶었음...
                                                                                //근데 좀 이상해짐;;;
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

    public void OnPointerUp(PointerEventData _eventData) // 어느 슬롯에서 뗏는지 찾기 ( 마우스 포인터를 떼면??0
    {
        if (selectedSlotIndex == -1 )  //비어있는 슬롯일 경우 아래의 코드를 실행하지 않아도 된다
        {
           return;  
        }

      

        //selectedIcon.gameObject.SetActive(false);


        int tmpIconIndex = -1;  //임의의 정수 변수 tmpIconIndex를 -1로 설정해줌

        for (int i = 0; i < slotList.Count; i++)   //슬롯 위치임! 내가 마우스 포인터를 뗐을 때의 위치를 알고싶음.
                                                    //똑같이 내가 마우스를 뗀 위치를 알기 위해 슬롯의 갯수만큼 for문을 돌려줌
        {
            if (slotList[i].isInRect(_eventData.position))  //내가 마우스를 뗀 위치가 만약 슬롯 안이라면????
            {
                tmpIconIndex = i;   //임시변수는 슬롯을 뗀 위치임
                break;
            }
        }

        // tmpIconIndex 값이 -1이 아닌 경우 아이템 이미지를 교체한다
        // selectedIconIndex랑 slotList의 uiimage랑 바꾼다
        // 

        if(tmpIconIndex != -1)  //슬롯이 비어있지 않다면
        {
            Sprite tmp = selectedIcon.sprite;   // 끌려다니는 이미지를 tmp 변수에 임시로 저장해놓고
            slotList[selectedSlotIndex].uiIcon.sprite = slotList[tmpIconIndex].uiIcon.sprite;
            //내가 다우스를 뗀 위치의 슬롯 이미지가 첫번째 슬롯 이미지에 대입된다
            slotList[tmpIconIndex].uiIcon.sprite = tmp;
            //끌려다니는 이미지가 마우스를 뗀 위치의 슬롯 이미지로 교체된다


            //Sprite tmp = selectedIcon.sprite;
            //slotList[tmpIconIndex].uiIcon.sprite = slotList[selectedSlotIndex].uiIcon.sprite;
            //slotList[selectedSlotIndex].uiIcon.sprite = tmp;      //이렇게 하면 첫번째 선택한 아이콘이 복사댐

            selectedIcon.gameObject.SetActive(false);   //복사가 완료되면 따라다니는 이미지를 비활성화한다
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
