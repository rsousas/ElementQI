using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{

	private int buttoWidth = 200;
	private int buttonHeight = 50;
	private string winner;

	public GUIStyle styleTurn, styleWait, styleWinner;

	// Use this for initialization
	void Start ()
	{
		styleWait.normal.textColor = Color.blue;
		styleWinner.normal.textColor = styleWait.normal.textColor;
		winner = "Jogador 2 está vencendo!!!";
		if (Level1Script.scoresPlayer1 > Level1Script.scoresPlayer2) {
			styleWinner.normal.textColor = styleTurn.normal.textColor;
			winner = "Jogador 1 está vencendo!!!";
		} else if (Level1Script.scoresPlayer1 == Level1Script.scoresPlayer2) {
			styleWinner.normal.textColor = Color.gray;
			winner = "Está empatado!!!";
		}



		styleTurn.fontSize = 15;
		styleWait.fontSize = 15;
		  
		//styleWinner.normal.textColor = Color.gray;
		styleWinner.fontSize = 20;
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



		if (GUI.Button (new Rect (Screen.width / 2 - buttoWidth / 2, Screen.height / 2 - buttonHeight / 2, buttoWidth, buttonHeight), "Pŕoximo Level >>>")) {//"Parabéns "+ winner + "! Você Venceu!!! \n Jogar Novamente?")) {

			//Level1Script.scoresPlayer1 = 0;
			//Level1Script.scoresPlayer2 = 0;

			SceneManager.LoadScene (4);
		}

		if (GUI.Button (new Rect (Screen.width / 2 - buttoWidth / 2, Screen.height / 2 + 100, buttoWidth, buttonHeight), "< Sair >")) {
			Level1Script.scoresPlayer1 = 0;
			Level1Script.scoresPlayer2 = 0;

			SceneManager.LoadScene (0);
		}
	}
}
