using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class _10_18_Slot : MonoBehaviour
{
    
    public Image uiIcon; //�������� ������ �˰� �־�� �� (������)
   
    public RectTransform rcTransform; //������ ��ġ�� �˰� �־�� �� (����)

    Rect rc;    //rect ����ü�� ��ġ�� �»������ ��������
    public Rect RC
    {
        get 
        {
            rc.x = rcTransform.position.x - rcTransform.rect.width*0.5f;
            rc.y = rcTransform.position.y + rcTransform.rect.height * 0.5f;
            return rc;
        }
    }


    void Start()
    {
        rc.x = rcTransform.position.x - rcTransform.rect.width * 0.5f;
        rc.y = rcTransform.position.y + rcTransform.rect.height * 0.5f;
        rc.width = rcTransform.rect.width;
        rc.height = rcTransform.rect.height;
        rc.xMax = rc.xMin + rcTransform.rect.width;
        rc.xMax = rc.xMin + rcTransform.rect.height;
    }

    
    void Update()
    {
        
    }

    public bool isInRect(Vector2 _pos)
    {
        if (_pos.x >= RC.x &&
            _pos.x <= RC.x + RC.width &&
            _pos.y >= RC.y - RC.height &&
            _pos.y <= RC.y
            )
            return true;
        return false;
    }

}
