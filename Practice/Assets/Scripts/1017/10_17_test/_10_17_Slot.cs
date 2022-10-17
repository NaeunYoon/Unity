using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
    

public class _10_17_Slot : MonoBehaviour
{
    public Image icon;  // �� ������ �ڽ�imgage�� icon  -> uiIcon

    public int count;

    private RectTransform rcTransform;  // ������ rectransform;
    private Rect rc; // �ܺο��� set���ϰ� �Ϸ��� ������Ƽ�� ����
    private Rect RC // �ܺο��� set���ϰ� �Ϸ��� ������Ƽ�� ����
    {
        get
        {
            rc.x = rcTransform.position.x - rcTransform.rect.width * 0.5f;
            rc.y = rcTransform.position.y + rcTransform.rect.height * 0.5f;
            //Debug.Log($"22rc.x {rc.x} || {rc.xMin} || {rc.width}");
            return rc;
        }
    }    // �̰� �»��, ���ϴ����� �ؼ� ���� -> ���� �������� ���α׷���, ���� ����Ƽ ���

    void Start()
    {
        rcTransform = GetComponent<RectTransform>();
        Debug.Log($"rcTransform.position {rcTransform.position} || {rcTransform.rect.width * 0.5f}");
        rc.x = rcTransform.position.x - rcTransform.rect.width * 0.5f;    // RC ���� ������ �̰� �ʿ����
        rc.y = rcTransform.position.y + rcTransform.rect.height * 0.5f;   // RC ���� ������ �̰� �ʿ����
        //Debug.Log($"11rc.x {rc.x}");
        //rc.xMin = rc.x;   // �̰͵� �ʿ��Ѱ� x��ǥ�� �ּҰ��� ��������� �� �����Ǵ°� �ƴѰ�?
        //rc.yMin = rc.y;    // �̰� ��ɷ� �����ϴ� �Ʒ��� width height������ �ϰԵǸ� �ڵ����� �ʱ�ȭ�� �̷������.
        rc.xMax = rc.xMin + rcTransform.rect.width;
        rc.xMax = rc.xMin + rcTransform.rect.height;
        rc.width = rcTransform.rect.width;
        rc.height = rcTransform.rect.height;
        //Debug.Log($"22rc.x {rc.x}");
    }

    /// <summary>
    /// �Ű������� ���� �� _pos�� rc�� ���� �Ǵ��� �ƴ��� �˻�
    /// </summary>
    /// <param name="pos">���� ������ ��ġ ��ġ(���� ������)</param>
    /// <returns></returns>
    public bool IsInRect(Vector2 _pos)
    {
        Debug.Log(_pos.x >= RC.x);
        Debug.Log($"{_pos.x} ||{RC.x}|| {RC.width}|| {_pos.x <= RC.x + RC.width}");
        Debug.Log(_pos.y <= RC.y);
        Debug.Log(_pos.y >= RC.y + RC.height);
        if (_pos.x >= RC.x
            && _pos.x <= RC.x + RC.width
            && _pos.y <= RC.y
            && _pos.y >= RC.y - RC.height)
        {
            return true;
        }
        return false;
    }
}
