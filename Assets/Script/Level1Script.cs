using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Script : MonoBehaviour {

	public static int scoresPlayer1 = 0;
	public static int scoresPlayer2 = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 105, 20), "Player 1:" + Level1Script.scoresPlayer1.ToString ());
		GUI.Label (new Rect (10, 30, 105, 20), "Player 2:" + Level1Script.scoresPlayer2.ToString ());
	}
}
