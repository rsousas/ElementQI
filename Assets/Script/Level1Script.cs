using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Script : MonoBehaviour {

	public static int scores = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 105, 20), "Pontuação: " + Level1Script.scores.ToString ());
	}
}
