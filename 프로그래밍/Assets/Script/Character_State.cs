using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_State : MonoBehaviour {

    public string ChracterName; //캐릭터 이름

    //체력, 정신력, 건강 (0 ~ 150)
    public int Strength;
    public int Mental;
    public int Health;

    //체력검사, 정신력 검사, 건강검사
    public bool StrengthEmpty;
    public bool MentalEmpty;
    public bool HealthEmpty;

    //생존여부, 0인 생존여건 수
    public bool isDead;
    public int isDeadFlag;

    //회복력, 안정도, 위생도 (0 ~ 120)
    public int Recovery;
    public int Stability;
    public int Clean;

    //회복력 상태, 안정도 상태, 위생도 상태 (1 ~ 3)
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

    //관계 체크 (1 ~ 3)
    public int RelationshipCheck;


    //관계 수치에 따른 관계 설정
    public void Reration(int relation)
    {
        if (relation <= 45)
            RelationshipCheck = 1;
        else if (relation > 45 && relation <= 85)
            RelationshipCheck = 2;
        else if (relation > 85)
            RelationshipCheck = 3;
    }

    //생존여건 검사
    public void StrengthFlag()
    {
        if (Strength <= 0)
        {
            if (StrengthEmpty == true)
                isDeadFlag++;
            StrengthEmpty = true;
        }
        else
        {
            if (StrengthEmpty == false)
                isDeadFlag--;
            StrengthEmpty = false;
        }
    }
    public void MentalFlag()
    {
        if (Mental <= 0)
        {
            if (MentalEmpty == true)
                isDeadFlag++;
            MentalEmpty = true;
        }
        else
        {
            if (MentalEmpty == true)
                isDeadFlag++;
            MentalEmpty = false;
        }
    }
    public void HealthFlag()
    {
        if (Health <= 0)
        {
            if (HealthEmpty == true)
                isDeadFlag++;
            HealthEmpty = true;
        }
        else
        {
            if (HealthEmpty == false)
                isDeadFlag--;
            HealthEmpty = false;
        }
    }
    public void DeadFlag()
    {
        if (isDeadFlag >= 2)
            isDead = true;
        else
            isDead = false;
    }
}
