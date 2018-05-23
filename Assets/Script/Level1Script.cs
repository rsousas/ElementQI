using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Script : MonoBehaviour {

	public static int scoresPlayer1 = 0;
	public static int scoresPlayer2 = 0;
	public GUIStyle styleTurn, styleWait, stylePlayer1, stylePlayer2;
    

    // Use this for initialization
    void Start () {
        AudioScript.PlaySound("musica");
		//styleTurn.normal.textColor = 79514F;
        styleWait.normal.textColor = Color.blue;
		styleTurn.fontSize = 20;
		styleWait.fontSize = 20;

		//stylePlayer1.normal.textColor = 79514F;
		stylePlayer1.fontSize = 45;
		stylePlayer2.normal.textColor = Color.blue;
		stylePlayer2.fontSize = 45;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		
		GUI.Label(new Rect(20, 30, 105, 20), "Jogador 1: " + Level1Script.scoresPlayer1.ToString(), styleTurn);
		GUI.Label(new Rect(20, 50, 105, 20), "Jogador 2: " + Level1Script.scoresPlayer2.ToString(), styleWait);
        if (GeraGrids.player) {
			GUI.Label(new Rect(500, 25, 105, 20), "Vez do jogador 1", stylePlayer1);
        } 
        else {
			GUI.Label(new Rect(500, 25, 105, 20), "Vez do jogador 2", stylePlayer2);
        }
	}
}
