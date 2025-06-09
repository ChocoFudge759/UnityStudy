using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    public TextMeshProUGUI Txt_Gacha;

    string[] character = { "고은식", "권도영", "권우중", "김경빈", "김귀령", "김도형", "김민영", "김상준", 
        "김성헌", "김예성", "김재협", "김지원", "김태현", "김한나", "노민석", "목승환", "문혜준", "민송희", 
        "박건태", "박민수", "박성빈", "박시원", "박재완", "박재환", "박준석", "박지원", "박현아", "배소정", 
        "백승헌", "손석현", "신수용", "신승환", "신채현", "안정환", "양승화", "양현지", "엄지성", "원대연", 
        "원중완", "윤사무엘", "이강민", "이경식", "이규진", "이동욱", "이민호", "이상록", "이상엽", "이성훈", 
        "이승준", "이원림", "이유경", "이윤호", "이준모", "이창호", "이채성", "이호범", "장재호", "정승원", 
        "정은교", "정호진", "조규현", "조민식", "조성재", "조인영", "조지현", "조형민", "차정훈", "천지수", 
        "최문석", "최현석", "한세웅", "허재영", "홍서빈" };
    List<string> characterList = new List<string>();


    public void ListGacha() // characterList.Count
    {
        List<string> gachaList = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            gachaList.Add(characterList[Random.Range(0, characterList.Count)]);
            Debug.Log(gachaList);

        }
        Debug.Log("가챠 목록\n" + string.Join(", ", gachaList));
        Txt_Gacha.text = "가챠 목록이 출력됐습니다.\n";

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
        Debug.Log("뭐라도 나와라" + characterList);
    }
}