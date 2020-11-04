using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_State : MonoBehaviour {

    //체력, 정신력, 건강 (0 ~ 150)
    public int Strength;
    public int Mental;
    public int Health;

    //체력검사, 정신력 검사, 건강검사
    public bool StrengthEmpty;
    public bool MentalEmpty;
    public bool HealthEmpty;

    //생존여부
    public bool isDead;

    //회복력, 안정도, 위생도 (0 ~ 120)
    public int Recovery;
    public int Stability;
    public int clean;

    //회복력 상태, 안정도 상태, 위생도 상태 (0 ~ 3)
    public int RecoveryState;
    public int StabilityState;
    public int CleanState;

    //성별확인
    public bool isFemale;

    //기본호감도, 누적호감도, 호감도
    public int BasicFeeling;           // 0 ~ 100
    public int CumulativeFeeling;      // -999 ~ 999
    public int Feeling;                // 0 ~ 999

    //관계 (나르키, 그리디아, 페시호, 로브 순) (0 ~ 100)
    public int[] Relationship = new int[4];

    //관계 체크 (0 ~ 3)
    public int RelationshipCheck;

}
