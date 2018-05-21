using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Script : MonoBehaviour {

	public static int scoresPlayer1 = 0;
	public static int scoresPlayer2 = 0;
    public GUIStyle styleTurn, styleWait;
    

    // Use this for initialization
    void Start () {
        styleTurn.normal.textColor = Color.green;
        styleWait.normal.textColor = Color.black;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
        if (GeraGrids.player) {
            GUI.Label(new Rect(20, 30, 105, 20), "Jogador 1:" + Level1Script.scoresPlayer1.ToString(), styleTurn);
            GUI.Label(new Rect(20, 60, 105, 20), "Jogador 2:" + Level1Script.scoresPlayer2.ToString(), styleWait);
        }
        else {
            GUI.Label(new Rect(20, 30, 105, 20), "Jogador 1:" + Level1Script.scoresPlayer1.ToString(), styleWait);
            GUI.Label(new Rect(20, 60, 105, 20), "Jogador 2:" + Level1Script.scoresPlayer2.ToString(), styleTurn);
        }
	}
}
