using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript2 : MonoBehaviour {

	private int buttoWidth = 200;
	private int buttonHeight = 50;
    private string winner;


	public GUIStyle styleTurn, styleWait, styleWinner;

	// Use this for initialization
	void Start ()
	{
		styleWait.normal.textColor = Color.blue;
		styleWinner.normal.textColor = styleWait.normal.textColor;
		winner = "Jogador 2 você venceu!!!";
		if (Level1Script.scoresPlayer1 > Level1Script.scoresPlayer2) {
			styleWinner.normal.textColor = styleTurn.normal.textColor;
			winner = "Jogador 1 você venceu!!!";
		} else if (Level1Script.scoresPlayer1 == Level1Script.scoresPlayer2) {
			styleWinner.normal.textColor = Color.yellow;
			winner = "Oppss! Ficou empatado!!!";
		}



		styleTurn.fontSize = 13;
		styleWait.fontSize = 13;

		//styleWinner.normal.textColor = Color.yellow;
		styleWinner.fontSize = 25;

		styleWinner.fontStyle = FontStyle.Bold;
	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnGUI ()
	{


		GUI.Label (new Rect (400, 30, 105, 20), winner, styleWinner);

		GUI.Label (new Rect (20, 30, 105, 20), "Pontuação Jogador 1: " + Level1Script.scoresPlayer1.ToString (), styleTurn);
		GUI.Label (new Rect (20, 50, 105, 20), "Pontuação Jogador 2: " + Level1Script.scoresPlayer2.ToString (), styleWait);

		if (GUI.Button (new Rect (Screen.width / 2 - buttoWidth / 2, Screen.height / 2 - buttonHeight / 2, buttoWidth, buttonHeight), "< Finalizar >")){
			Level1Script.scoresPlayer1 = 0;
			Level1Script.scoresPlayer2 = 0;

			SceneManager.LoadScene(0);
			}
	}
}
