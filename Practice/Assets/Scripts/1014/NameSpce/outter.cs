using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Study01;    //1.
                    // �ٸ� ��ũ��Ʈ���� ����� ���ӽ����̽��� �Ǵٸ� ��ũ��Ʈ���� ����ϱ� ����
                    // using �������ش�
                    //�����غ�� ��� ������ �ֳĸ� ��¡�ϰų� ���ӽ����̽� �����Ա� ������ ��
                    //�ν�����â�� ���� �ʰ����� �����غ� ��ӹ��� �ٸ� Ŭ���� �ȿ��� �ҷ����°� ����

public class outter : MonoBehaviour
{
    
    void Start()
    {
        Study01._NameSoceSample ns = new Study01._NameSoceSample();     //2. Ŭ������ ���ӽ����̽��� �����ؼ� ������ �Ҵ����ش�
                                                                        //Ŭ������ new�� ���Ӱ� �޸𸮸� �Ҵ����ش�
                                                                        //����.�Լ��� �����ؼ� �ٸ� ��ũ��Ʈ�� �ִ� ���ӽ����̽�>Ŭ����> �Լ� �ҷ��´�
        ns.Show();

        //_NameSoceSample ns = new _NameSoceSample();       //���ӽ����̽��� ����ؼ� �Լ��� ȣ���ϴ� 1�� ���
        //ns.Show();                                         using�� �Ǿ� ������ �ٷ� Ŭ������ ȣ�����ְ� ������ �Ҵ����ش�
                                                            //�Ҵ�� ������ ���� ����� �޸��� �ּҰ��� ����Ų��
                                                             // new �� �� �޸𸮿� �Ҵ����ش�
                                                             //Ŭ����
    }

    
    void Update()
    {
        
    }
}
