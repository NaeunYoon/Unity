using UnityEngine;
/*
 ���ӽ����̽��� �����ϰ� �ִ� ��

1. ���ӽ����̽�
2. Ŭ����
3. ����ü
4. �������̽�
 
 */

namespace Study01
{
    namespace Study02
    {
        public class Test02
        {

        }
    }

    public class _NameSoceSample    //������� ������ �ν�����â�� �ٰ�,
                                    //��� ���ӽ����̽� ���ؼ� �ٸ� ��ũ��Ʈ���� ��� ����
    {
        public int num1 = 10;

        public void Show()
        {
            Debug.Log("���͵� ����");
        }
    }
    public class Test01
    {
        public int num2;
    }

    struct SampleStruct
    {
        public string Name;
    }

    interface Istudy
    {
        void IstudyStart();
    }


}

