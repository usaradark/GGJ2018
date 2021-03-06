﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicroWave_Click : MonoBehaviour {

	public static string correctCode = "7845";
	public static string playerCode = "";

	public static int totalDigits = 0;

	public static string didclick = "n";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (playerCode);

		if (totalDigits == 4) 
		{
			if (playerCode == correctCode) {
				//Debug.Log ("Correct");
			} 

			else 
			{
				playerCode = ("");
				totalDigits = 0;
					
				//Debug.Log ("You are the weakest link!");
			}
		}
	}

	void OnMouseUp()
		{
		playerCode += gameObject.name;
		totalDigits += 1;
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 0);
		StartCoroutine (waittochange());
		didclick = "y";
		}

	void OnMouseOver()
	{
		if (didclick == "n")
		GetComponent<SpriteRenderer> ().color = new Color (0, 1, 0);
		//Debug.Log ("Hovering");
	}

	void OnMouseExit()
	{
		if (didclick == "n")
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);
		//Debug.Log ("Not Hovering");
	}

	IEnumerator waittochange()
	{
		yield return new WaitForSeconds (1);
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);
		didclick = "n";
	}
}
