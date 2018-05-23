using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour {

	private int buttoWidth = 200;
	private int buttonHeight = 50;
    private string winner;

    // Use this for initialization
    void Start () {
        AudioScript.PlaySound("aplausos");
    }

	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
        winner = "Jogador 2";
        if (GeraGrids.player)
            winner = "Jogador 1";

        if (GUI.Button (new Rect (Screen.width / 2 - buttoWidth / 2, Screen.height / 2 - buttonHeight / 2, buttoWidth, buttonHeight), "Parabéns "+ winner + "! Você Venceu!!! \n Jogar Novamente?")) {

			Level1Script.scoresPlayer1 = 0;
			Level1Script.scoresPlayer2 = 0;

			SceneManager.LoadScene(1);
		}
	}
}
