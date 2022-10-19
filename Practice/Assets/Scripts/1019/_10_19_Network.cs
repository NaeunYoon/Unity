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

        //ip를 byte배열로 바꾼다
        byte[] b1 = ip1.GetAddressBytes();
        Debug.Log($"Address :{b1[0]}, {b1[1]}, {b1[2]}, {b1[3]}");

        byte[] b2 = ip2.GetAddressBytes();
        Debug.Log($"Address :{b2[0]}, {b2[1]}, {b2[2]}, {b2[3]}");

        byte[] b3 = ip3.GetAddressBytes();      //이건 누구의 주소인가여?
        Debug.Log($"Address :{b3[0]}, {b3[1]}, {b3[2]}, {b3[3]}");

        //b2를 long 값으로 변경   //long값은 .....uint32로 바꿔여? 왜바꿔요
        long ip = BitConverter.ToUInt32(b2,0);
        Debug.Log("ip =" + ip.ToString());  //누군지 모르는 사람의 주소를 정수로 바꾼거
    }
    static void Domain()
    {
        IPHostEntry hostEntry = Dns.GetHostEntry("www.naver.com");
        Debug.Log(hostEntry.HostName);  //네이버 호스트이름 나옴

        foreach(IPAddress one in hostEntry.AddressList)
        {
            Debug.Log(one); //네이버 ipv4
            Debug.Log(one.MapToIPv6());   //네이버ipv6
        }

        string hostName = Dns.GetHostName();    //나의 로컬 호스트 호출
        Debug.Log("로컬호스트 : "+ hostName);    //호스트 이름 나옴
        IPHostEntry localHost = Dns.GetHostEntry(hostName); //호스트 이름으로부터 ip 가져옴
        foreach(IPAddress one in localHost.AddressList)
        {
            Debug.Log("로컬ip : " + one); //ipv4 ipv6 나옴
        }
    }
    /*
     IPHostEntry : 인터넷 호스트 주소 정보에 컨테이너 클래스를 제공 (무슨말이야;)
     	
     IPAddress.Parse : IP 주소 문자열을 IPAddress 인스턴스로 변환합니다.
     
     IPv4 : 점 구분 네 자리 표기법으로 표현된 IP 주소
     IPv6 : 콜론과 16진수 표기법으로 표현된 IP 주소
     IPAdress() :  IP(인터넷 프로토콜) 주소를 제공
     MapToIPv6() : IPAddress 개체를 IPv6 주소로 매핑
     */

    void Update()
    {
        
    }
}
