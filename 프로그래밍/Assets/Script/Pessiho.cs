using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pessiho : MonoBehaviour {

    private Character_State PessihoState = new Character_State();

    // Use this for initialization
    void Start () {

        PessihoState.Strength = 81;
        PessihoState.Mental = 35;
        PessihoState.Health = 66;

        PessihoState.StrengthEmpty = true;
        PessihoState.MentalEmpty = true;
        PessihoState.HealthEmpty = true;

        PessihoState.isDeadFlag = 0;
        PessihoState.isDead = false;

        PessihoState.Recovery = 71;
        PessihoState.Stability = 21;
        PessihoState.Clean = 55;

        PessihoState.RecoveryState = 2;
        PessihoState.StabilityState = 1;
        PessihoState.CleanState = 2;

        PessihoState.Relationship[0] = 29;
        PessihoState.Relationship[1] = 65;
        PessihoState.Relationship[2] = 47;

        PessihoState.isFemale = true;

        PessihoState.SetFeeling(63);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
