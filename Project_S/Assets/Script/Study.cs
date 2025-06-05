using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study : MonoBehaviour
{
    // 이름 나이 혈액형 MBTI 키 성별 경력 사는곳 알레르기 취미, 최애겜
    

    void Start()
    {
        selfIntroduction();
    }

    public void selfIntroduction ()
    {
        Debug.Log($"제 이름은 {name}입니다.\n" +
            $"나이는 {age}이고, 혈액형은 {bloodType}입니다.\n" +
            $"MBTI는 {mbti}, 키는 {height}, 성별은 {sex}입니다.\n" +
            $"거주지역은 {residence}이며, {allergy} 알레르기가 있습니다.\n" +
            $"취미는 {hobby} 이고, 제일 좋아하는 게임은 {favoriteGame}입니다.");
    }
}
