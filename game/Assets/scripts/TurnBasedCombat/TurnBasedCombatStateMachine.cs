﻿using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {




	public enum BattleStates{
		START,
		PLAYERCHOICE,

		ENEMYCHOICE,
		LOSE,
		WIN
	}
	private BattleStates currentState;

	// Use this for initialization
	void Start () {
		currentState = BattleStates.START;
	}
	void Update () {
		Debug.Log (currentState);
		switch(currentState){
		case(BattleStates.START):
			//setup battle fn
			break;
		case(BattleStates.ENEMYCHOICE):
			break;
		case(BattleStates.LOSE):
			break;
		case(BattleStates.PLAYERCHOICE):
			break;
		case(BattleStates.WIN):
			break;
		}

	}
	void OnGUI(){
		if (GUILayout.Button ("Next State")) {
			if(currentState == BattleStates.START){
				currentState = BattleStates.PLAYERCHOICE;
			}else if(currentState == BattleStates.PLAYERCHOICE){
				currentState = BattleStates.ENEMYCHOICE;
			}else if(currentState == BattleStates.ENEMYCHOICE){
				currentState = BattleStates.LOSE;
			}else if(currentState == BattleStates.LOSE){
				currentState = BattleStates.WIN;
			}else if(currentState == BattleStates.WIN){
				currentState = BattleStates.START;
			}
		}
	}
}