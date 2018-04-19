using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	private int buttonWidth = 200;
	private int buttonHeight = 50;
	public Texture fundoTexture;
	public GUISkin MainMenuSkin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI (){

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fundoTexture);
		GUI.skin = MainMenuSkin;

		if (GUI.Button (new Rect (Screen.width / 4 - buttonWidth / 2, Screen.height / 1.15f  - buttonHeight / 2, buttonWidth, buttonHeight), "NÍVEL")) {
			SceneManager.LoadScene(2);
		}
			

		if (GUI.Button (new Rect (Screen.width / 2 - buttonWidth / 2, Screen.height / 1.15f - buttonHeight / 2, buttonWidth, buttonHeight), "JOGAR")) {
			SceneManager.LoadScene(1);
		}

		if (GUI.Button (new Rect (Screen.width / 1.34f- buttonWidth / 2, Screen.height / 1.15f - buttonHeight / 2, buttonWidth, buttonHeight), "SAIR")) {
			Application.Quit();
		} 

		// if (Input.anyKeyDown)
		//	SceneManager.LoadScene(1);

	}
}
