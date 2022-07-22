using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string title2 = "������";
    string playerName2 = "���";
    int health2 = 30;
    int level2 = 5;
    float strength2 = 15.5f;
    int exp2 = 1500;
    int mana2 = 25;
    bool isFullLevel2=false;


    int health = 30; //�������� : �Լ� �ٱ��� ����� ����
    //����� �ʼ� �����͸� ���� ���� ��������

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");

        //--------������ ����( �̸��� �ִ� ���� ����, ���� �ִ� ���� �ʱ�ȭ ��� ��
        //������
        int level = 5;
        //�Ǽ���, ���� �� f ���̱�
        float strength=15.5f;
        //����
        string playerName = "������";
        //����(��,����)
        bool isFullLevel=false;

        //--------�׷��� ����(1)
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        //--------�׷��� ����(2)
        int[] monsterLevel = new int[3];
        
        monsterLevel[0] = 1;
        monsterLevel[1] = 5;
        monsterLevel[2] = 30;


        //--------����Ʈ

        List<string> items = new List<string>();
        //���� ��ȣ �ȿ��ٰ� �ڷ��� Ÿ���� �־���� �Ѵ� generic �̶�� �Ѵ�
        items.Add("������30");
        items.Add("��������30");
        items.RemoveAt(0);

        List<int> transform=new List<int>();
        transform.Add(1);
        //ũ�⸦ ��� Ž���� ������ �߻� (�ε��� ����)

        //--------������ ( ��� ���� ���� �������ִ� ��ȣ)
        int exp=1500;
        exp = 1500 + 320; //���ϱ�
        exp = exp - 10; //����
        level = exp / 300; //������
        strength = level * 3.1f; //���ϱ�(���� ������ ����ؼ� 3.1��ŭ �����Ѵ�)
        int nextEXP = 300 - (exp % 300); //������ ������ 

        //--------���ڿ�
        string title = "������";

        //--------�񱳿�����(>,<,>=,<=)
        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        bool isEndTutorial = level > 10;

        //--------��������(&& �� ���� ��� true�� �� ���)
        int health = 30;
        int mana = 15;
        //bool isBadCondition = health <= 50 && mana <= 20;

        //--------��������(|| �� �� �� �ϳ��� true�̸� true ���)
        bool isBadCondition = health <= 50 || mana <= 20;

        //--------��������(?A:B: TRUE�� �� A, FALSE�� �� B ���)
        string condition = isBadCondition ? "����" : "����";

        //--------Ű����(���α׷��� �� �����ϴ� Ư���� �Ǹ��� ��� �ܾ�)
        //���� �̸��̳� ������ ����� �� ����

        //--------���ǹ�
        //if ������true�� ��, ���� ����
        //else ���� if�� ������� ������ ����

        //--------switch,case : ������ ���� ���� ���� ����
        //default : ��� case�� ����� �� ����
        //cese���� ���� ������ ���� ������ �����Ѵ�

        //--------�ݺ��� ( ���ǿ� �����ϸ� ������ �ݺ��ϴ� ���)
        //while : ������ true �� �� ������ ����
        //for : ������ �����ϸ鼭 ���� �ݺ� ����

        //--------���� ����
        //.Length (�迭)
        //.Count (����Ʈ)

        //--------foreach : for�� �׷��� ���� Ž�� Ưȭ
        //���� �׷��� ���� �ȿ� �ִ� �������� �ϳ��� ������� �߰�ȣ �ȿ��� ���� ���

        //�Լ� : �������� ����� ���ϰ� ����ϵ��� ������ ����

        //Ŭ���� : �ϳ��� �繰(������Ʈ)�� �����ϴ� ����
        //Ŭ���� : Ŭ���� ���� ���
        Player player = new Player();

        player.id = 0;
        player.name = "������";
        player.title = "����";
        player.strength = 2.4f;
        player.weapon = "��ġ";
       

        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������"+ player.level+"�Դϴ�");
        Debug.Log(player.move());



        //Ÿ�� ��ſ� Ŭ���� �̸� / ���� ��/ = / new class():
        //�� Ŭ������ �ϳ��� ������ ����� �� ( �ν��Ͻ� : ���ǵ� Ŭ������ ���� �ʱ�ȭ�� ��üȭ
        //������ ���� 



        //���α׷����� ����-�ʱ�ȭ-ȣ��(���) ������ ��

        //����
        Debug.Log("����� �̸���?");
        Debug.Log(playerName);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);
        //�迭
        Debug.Log("�ʿ� �����ϴ� ����");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        Debug.Log("�ʿ� �����ϴ� ���� ������?");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);
        //����Ʈ (�迭���� �ٸ��� �ȿ� �ִ� ������ ������ ����)
        Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);
        //������
        Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextEXP);
        Debug.Log("����� �̸���?");
        Debug.Log(title+" "+playerName);
        //�񱳿�����
        Debug.Log("���� �����Դϱ�?"+" "+ isFullLevel);
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�?" + " " + isEndTutorial);
        //��������
        Debug.Log("����� ���°� ���޴ϱ�?" + " " + isBadCondition);
        Debug.Log("����� ���°� ���޴ϱ�?" + " " + condition);
        //if ���ǹ�
        if (condition == "����")
        {
            Debug.Log("����� ���°� ���ڴ� �������� ����ϼ���");
        }
        else
        {
            Debug.Log("�÷��̾��� ���°� �����ϴ�");
        }

        if (isBadCondition && items[0]=="������30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("�������� ����Ͽ����ϴ�");
        }
        else if(isBadCondition && items[0] == "��������30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("���������� ����Ͽ����ϴ�");
        }

        //switch,case

        switch (monsters[1])
        {
            case "������":
            case "�縷��":
                Debug.Log("���� ���Ͱ� ����");
                break;
            case "�Ǹ�":
                Debug.Log("���� ���Ͱ� ����");
                break;
            case "��":
                Debug.Log("���� ���Ͱ� ����");
                break;
            default:
                Debug.Log("??? ���Ͱ� ����");
                break;
                    
        }
        //�ݺ��� while
        while (health > 0)
        {
            health--;
            if (health > 0)
            {

                Debug.Log("�� �������� �Ծ����ϴ�" + " " + health);
            }
            else
            {
                Debug.Log("����Ͽ����ϴ�");
            }
            if(health == 10)
            {
                Debug.Log("�ص����� ����մϴ�");
                break ;
            }
        }
        //for��
        for(int count=0; count<10; count++)
        {
            health++;
                Debug.Log("�ش�ġ����.."+" "+health);
        }
        //�׷��� ���� ����
        for (int index = 0; index < monsters.Length; index++)
        {
            
            Debug.Log("�� ������ �ִ� ����.." + " " + monsters[index]);
        }
        //foreach

        foreach(string monster in monsters)
        {
            Debug.Log("�� ������ �ִ� ���� : " + " " + monster);
        }

        health = Heal(health);
        //�Ű������� ���� ����
        Heal2();

        for(int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("����" + monsters[index] + " ����" + Battle(monsterLevel[index]));
        }


    }

    //�Լ�
    //�Լ� �̸� �տ� �Լ��� ��ȯ�ϴ� �ڷ����� ����ϰ�, ��ȣ �ȿ��� �� �Լ��� ���� ������ ����
    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("���� �޾ҽ��ϴ�" + " " + currentHealth);
        return currentHealth;
        //�Լ��� ���� ��ȯ�� �� ��� ( �Լ� �տ� ��ȯ�ϴ� Ÿ���� ���� �� ���)
        //20���� 10 �޾Ƽ� 30 ���
    }
    //��ȯ �����Ͱ� ���� �Լ�Ÿ��
    void Heal2()
    {
        health += 10;
        Debug.Log("���� �޾ҽ��ϴ�" + " " + health);
        
    }
    //�������� : �Լ� �ȿ��� ����� ����
    //�������� : �Լ� �ۿ��� ����� ����

    string Battle(int monsterLevel)
    {
        string result;
        if (level2 >= monsterLevel)
        {
            result = "�̰���ϴ�";
        }
        else
        {
            result = "�����ϴ�";

            
        }
    return result;
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
