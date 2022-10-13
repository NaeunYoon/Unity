using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.EventSystems;
using UnityEngine.UI;

public class _10_13_Slot : MonoBehaviour
{
    public Image uiIcon;
    public RectTransform rcTransform;
    Rect rc;
    public Rect RC
    {
        get
        {
            rc.x = rcTransform.position.x - rcTransform.rect.width * 0.5f;
            rc.y = rcTransform.position.y + rcTransform.rect.height * 0.5f;
            return rc;
        }
    }

    void Start()
    {
        rc.x = rcTransform.position.x - rcTransform.rect.width * 0.5f;
        rc.y = rcTransform.position.y + rcTransform.rect.height * 0.5f;
        rc.xMin = rcTransform.rect.width;
        rc.yMin = rcTransform.rect.height;
        rc.width = rcTransform.rect.width;
        rc.height = rcTransform.rect.height;
    }

    
    void Update()
    {
        
    }

    public bool isInRect(Vector2 _pos)
    {
        if(_pos.x >= RC.x && _pos.x<= RC.x + RC.width && _pos.y  >= RC.y - RC.height&& _pos.y < RC.y)
            return true;
        return false;
    }

}
