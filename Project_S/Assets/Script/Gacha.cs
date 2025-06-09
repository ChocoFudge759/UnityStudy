using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    public TextMeshProUGUI Txt_Gacha;

    string[] character = { "������", "�ǵ���", "�ǿ���", "����", "��ͷ�", "�赵��", "��ο�", "�����", 
        "�輺��", "�迹��", "������", "������", "������", "���ѳ�", "��μ�", "���ȯ", "������", "�μ���", 
        "�ڰ���", "�ڹμ�", "�ڼ���", "�ڽÿ�", "�����", "����ȯ", "���ؼ�", "������", "������", "�����", 
        "�����", "�ռ���", "�ż���", "�Ž�ȯ", "��ä��", "����ȯ", "���ȭ", "������", "������", "���뿬", 
        "���߿�", "���繫��", "�̰���", "�̰��", "�̱���", "�̵���", "�̹�ȣ", "�̻��", "�̻�", "�̼���", 
        "�̽���", "�̿���", "������", "����ȣ", "���ظ�", "��âȣ", "��ä��", "��ȣ��", "����ȣ", "���¿�", 
        "������", "��ȣ��", "������", "���ν�", "������", "���ο�", "������", "������", "������", "õ����", 
        "�ֹ���", "������", "�Ѽ���", "���翵", "ȫ����" };
    List<string> characterList = new List<string>();


    public void ListGacha() // characterList.Count
    {
        List<string> gachaList = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            gachaList.Add(characterList[Random.Range(0, characterList.Count)]);
            Debug.Log(gachaList);

        }
        Debug.Log("��í ���\n" + string.Join(", ", gachaList));
        Txt_Gacha.text = "��í ����� ��µƽ��ϴ�.\n";

    }

    private void AddList()
    {
        for (int i = 0; i < character.Length; i++) // i < 8 -> 0 ~ 7
        {
            characterList.Add(character[i]);
        }
    }

    void Awake()
    {
        AddList();
        Debug.Log("���� ���Ͷ�" + characterList);
    }
}