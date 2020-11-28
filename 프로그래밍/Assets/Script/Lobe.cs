using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lobe : MonoBehaviour {

    private Character_State LobeState = new Character_State();

    // Use this for initialization
    void Start () {

        LobeState.Strength = 100;
        LobeState.Mental = 100;
        LobeState.Health = 100;

        LobeState.StrengthEmpty = true;
        LobeState.MentalEmpty = true;
        LobeState.HealthEmpty = true;

        LobeState.isDeadFlag = 0;
        LobeState.isDead = false;

        LobeState.Recovery = 100;
        LobeState.Stability = 100;
        LobeState.Clean = 100;

        LobeState.RecoveryState = 2;
        LobeState.StabilityState = 2;
        LobeState.CleanState = 2;

        LobeState.isFemale = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
