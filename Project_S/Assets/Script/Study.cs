using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study : MonoBehaviour
{
    // �̸� ���� ������ MBTI Ű ���� ��� ��°� �˷����� ���, �־ְ�
    

    void Start()
    {
        selfIntroduction();
    }

    public void selfIntroduction ()
    {
        Debug.Log($"�� �̸��� {name}�Դϴ�.\n" +
            $"���̴� {age}�̰�, �������� {bloodType}�Դϴ�.\n" +
            $"MBTI�� {mbti}, Ű�� {height}, ������ {sex}�Դϴ�.\n" +
            $"���������� {residence}�̸�, {allergy} �˷����Ⱑ �ֽ��ϴ�.\n" +
            $"��̴� {hobby} �̰�, ���� �����ϴ� ������ {favoriteGame}�Դϴ�.");
    }
}
