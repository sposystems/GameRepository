﻿using UnityEngine;
using System.Collections;

public class CreateNewScroll : MonoBehaviour {
	private BaseScroll newScroll;
	void Start(){
		CreateScroll ();
		Debug.Log (newScroll.ItemName);
		Debug.Log (newScroll.ItemDescription);
		Debug.Log (newScroll.ItemID.ToString());
		Debug.Log (newScroll.SpellEffectID.ToString());
		}
	private void CreateScroll(){
		newScroll = new BaseScroll();
		newScroll.ItemName = "Scroll";
		newScroll.ItemDescription = "This is a powerful Scroll";
		newScroll.ItemID = Random.Range (1, 101);
		newScroll.SpellEffectID = Random.Range (500, 1001);

		}
}
