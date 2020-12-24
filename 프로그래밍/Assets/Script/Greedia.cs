using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greedia : MonoBehaviour {

    private Character_State GreediaState = new Character_State();

    // Use this for initialization
    void Start () {

        GreediaState.Strength = 42;
        GreediaState.Mental = 110;
        GreediaState.Health = 56;

        GreediaState.StrengthEmpty = true;
        GreediaState.MentalEmpty = true;
        GreediaState.HealthEmpty = true;

        GreediaState.isDeadFlag = 0;
        GreediaState.isDead = false;

        GreediaState.Recovery = 31;
        GreediaState.Stability = 95;
        GreediaState.Clean = 45;

        GreediaState.RecoveryState = 1;
        GreediaState.StabilityState = 3;
        GreediaState.CleanState = 2;

        GreediaState.Relationship[0] = 87;
        GreediaState.Relationship[1] = 33;
        GreediaState.Relationship[2] = 37;

        GreediaState.isFemale = true;

        GreediaState.SetFeeling(82);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
