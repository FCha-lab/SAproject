using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lobe : MonoBehaviour {

    private Character_State LobeState = new Character_State();

    // Use this for initialization
    void Start () {

        LobeState.Strength = 61;
        LobeState.Mental = 75;
        LobeState.Health = 67;

        LobeState.StrengthEmpty = true;
        LobeState.MentalEmpty = true;
        LobeState.HealthEmpty = true;

        LobeState.isDeadFlag = 0;
        LobeState.isDead = false;

        LobeState.Recovery = 64;
        LobeState.Stability = 85;
        LobeState.Clean = 77;

        LobeState.RecoveryState = 2;
        LobeState.StabilityState = 2;
        LobeState.CleanState = 2;

        LobeState.isFemale = false;

        LobeState.SetFeeling(24);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
