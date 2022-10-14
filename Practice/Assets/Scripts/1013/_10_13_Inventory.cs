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
        selectedSlotIndex = 0;  //������ ������ ����Ʈ �ε����� 0���� �ʱ�ȭ
        //slotList = new List<_10_13_Slot>();


    }
    void Start()
    {
        selectedIcon.gameObject.SetActive(false);   //������ �������� ���� ���� �� ������ �ʰ� ���Ҽ�ȭ
    }

    public void OnPointerDown(PointerEventData _eventData)  //�����͸� ������ ��
    {

        //foreach(_10_13_Slot one in slotList)
        for (int i = 0; i < slotList.Count; i++)    //���� ���� ���� �ε����� ���� ������ for���� ������(�߿�)
        {
            if (slotList[i].isInRect(_eventData.position))  //���� ���� �������ʿ� ���� �ȿ� ���콺 �����Ͱ� �ִ��� �˻� ��
            {
                selectedSlotIndex = i;  //���õ� ���� �ε����� ���� ����Ʈ�� ��ȣ�� �Ҵ�ȴ� (���Ը���Ʈ ��ȣ = ���õ� ���� �ε���)
                selectedIcon.sprite = Resources.Load<Sprite>("Icons/" + slotList[i].uiIcon.sprite.name);   //���ҽ��̸� (�ε��ؼ� ����)
                //���� ������ ������ ������ ��������Ʈ�� �̸����� �˻��ؼ� ������ ����(�� ������) �� �ε�
                selectedIcon.rectTransform.position = _eventData.position;
                //���� Ŭ���ϴ� ���� ������ ������ �������
                selectedIcon.gameObject.SetActive(true);
                //������ ������� �� Ȱ��ȭ�����ش�
                Debug.Log("���ý���" + slotList[i].gameObject.name);     //������ ����
                //������ ������ �̸� ���
            }
        }
    }

    public void OnDrag(PointerEventData _eventData) //�ݺ��� �� �巡�װ� ���⋚���� ���!
    {
        if (selectedSlotIndex != -1)    //������ ������ �� ������ �ƴ϶��
        {
            selectedIcon.rectTransform.position = _eventData.position;  //�� ���Ը� �ƴϸ� ���� �巡���ϴ� �� �����Ӹ��� ���õ� �������� �������
            //slotList[selectedSlotIndex].uiIcon.gameObject.SetActive(false);   //���� �ű�� ���� �ִ� ������ �������� �ϰ�;���...
                                                                                //�ٵ� �� �̻�����;;;
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

    public void OnPointerUp(PointerEventData _eventData) // ��� ���Կ��� �´��� ã�� ( ���콺 �����͸� ����??0
    {
        if (selectedSlotIndex == -1 )  //����ִ� ������ ��� �Ʒ��� �ڵ带 �������� �ʾƵ� �ȴ�
        {
           return;  
        }

      

        //selectedIcon.gameObject.SetActive(false);


        int tmpIconIndex = -1;  //������ ���� ���� tmpIconIndex�� -1�� ��������

        for (int i = 0; i < slotList.Count; i++)   //���� ��ġ��! ���� ���콺 �����͸� ���� ���� ��ġ�� �˰����.
                                                    //�Ȱ��� ���� ���콺�� �� ��ġ�� �˱� ���� ������ ������ŭ for���� ������
        {
            if (slotList[i].isInRect(_eventData.position))  //���� ���콺�� �� ��ġ�� ���� ���� ���̶��????
            {
                tmpIconIndex = i;   //�ӽú����� ������ �� ��ġ��
                break;
            }
        }

        // tmpIconIndex ���� -1�� �ƴ� ��� ������ �̹����� ��ü�Ѵ�
        // selectedIconIndex�� slotList�� uiimage�� �ٲ۴�
        // 

        if(tmpIconIndex != -1)  //������ ������� �ʴٸ�
        {
            Sprite tmp = selectedIcon.sprite;   // �����ٴϴ� �̹����� tmp ������ �ӽ÷� �����س���
            slotList[selectedSlotIndex].uiIcon.sprite = slotList[tmpIconIndex].uiIcon.sprite;
            //���� �ٿ콺�� �� ��ġ�� ���� �̹����� ù��° ���� �̹����� ���Եȴ�
            slotList[tmpIconIndex].uiIcon.sprite = tmp;
            //�����ٴϴ� �̹����� ���콺�� �� ��ġ�� ���� �̹����� ��ü�ȴ�


            //Sprite tmp = selectedIcon.sprite;
            //slotList[tmpIconIndex].uiIcon.sprite = slotList[selectedSlotIndex].uiIcon.sprite;
            //slotList[selectedSlotIndex].uiIcon.sprite = tmp;      //�̷��� �ϸ� ù��° ������ �������� �����

            selectedIcon.gameObject.SetActive(false);   //���簡 �Ϸ�Ǹ� ����ٴϴ� �̹����� ��Ȱ��ȭ�Ѵ�
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
