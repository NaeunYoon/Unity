using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System;

public class _10_19_Network : MonoBehaviour
{
    static string serverIP = "211.104.182.195"; //ipv4

    void Start()
    {
        IPAdress();
        Domain();
    }

    static void IPAdress()
    {
        IPAddress ip1 = IPAddress.Parse(serverIP);
        IPAddress ip2 = new IPAddress(new byte[] { 211, 104, 182, 195 });
        IPAddress ip3 = new IPAddress(218212544);

        //ip�� byte�迭�� �ٲ۴�
        byte[] b1 = ip1.GetAddressBytes();
        Debug.Log($"Address :{b1[0]}, {b1[1]}, {b1[2]}, {b1[3]}");

        byte[] b2 = ip2.GetAddressBytes();
        Debug.Log($"Address :{b2[0]}, {b2[1]}, {b2[2]}, {b2[3]}");

        byte[] b3 = ip3.GetAddressBytes();      //�̰� ������ �ּ��ΰ���?
        Debug.Log($"Address :{b3[0]}, {b3[1]}, {b3[2]}, {b3[3]}");

        //b2�� long ������ ����   //long���� .....uint32�� �ٲ㿩? �ֹٲ��
        long ip = BitConverter.ToUInt32(b2,0);
        Debug.Log("ip =" + ip.ToString());  //������ �𸣴� ����� �ּҸ� ������ �ٲ۰�
    }
    static void Domain()
    {
        IPHostEntry hostEntry = Dns.GetHostEntry("www.naver.com");
        Debug.Log(hostEntry.HostName);  //���̹� ȣ��Ʈ�̸� ����

        foreach(IPAddress one in hostEntry.AddressList)
        {
            Debug.Log(one); //���̹� ipv4
            Debug.Log(one.MapToIPv6());   //���̹�ipv6
        }

        string hostName = Dns.GetHostName();    //���� ���� ȣ��Ʈ ȣ��
        Debug.Log("����ȣ��Ʈ : "+ hostName);    //ȣ��Ʈ �̸� ����
        IPHostEntry localHost = Dns.GetHostEntry(hostName); //ȣ��Ʈ �̸����κ��� ip ������
        foreach(IPAddress one in localHost.AddressList)
        {
            Debug.Log("����ip : " + one); //ipv4 ipv6 ����
        }
    }
    /*
     IPHostEntry : ���ͳ� ȣ��Ʈ �ּ� ������ �����̳� Ŭ������ ���� (�������̾�;)
     	
     IPAddress.Parse : IP �ּ� ���ڿ��� IPAddress �ν��Ͻ��� ��ȯ�մϴ�.
     
     IPv4 : �� ���� �� �ڸ� ǥ������� ǥ���� IP �ּ�
     IPv6 : �ݷа� 16���� ǥ������� ǥ���� IP �ּ�
     IPAdress() :  IP(���ͳ� ��������) �ּҸ� ����
     MapToIPv6() : IPAddress ��ü�� IPv6 �ּҷ� ����
     */

    void Update()
    {
        
    }
}
