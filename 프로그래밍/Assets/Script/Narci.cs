using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narci : MonoBehaviour {

    private Character_State NarciState = new Character_State();

    // Use this for initialization
    void Start () {

        NarciState.Strength = 57;
        NarciState.Mental = 62;
        NarciState.Health = 39;

        NarciState.StrengthEmpty = false;
        NarciState.MentalEmpty = false;
        NarciState.HealthEmpty = false;

        NarciState.isDeadFlag = 0;
        NarciState.isDead = false;

        NarciState.Recovery = 62;
        NarciState.Stability = 45;
        NarciState.Clean = 29;

        NarciState.RecoveryState = 2;
        NarciState.StabilityState = 2;
        NarciState.CleanState = 1;

        NarciState.Relationship[0] = 50;
        NarciState.Relationship[1] = 34;
        NarciState.Relationship[2] = 52;

        NarciState.isFemale = true;

        NarciState.SetFeeling(42);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
