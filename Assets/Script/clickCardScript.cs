using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class clickCardScript : MonoBehaviour
{
	private ModalPanel modalPanel;
	private DisplayManager displayManager;

	private UnityAction myOp1Action;
	private UnityAction myOp2Action;
	private UnityAction myOp3Action;
	private UnityAction myOp4Action;
	private UnityAction myOp5Action;

	private int i, elemento; 
	private bool terminou;

	// Use this for initialization
	// void Start ()
	// {
		
	// }

	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseDown ()
	{		
		if (elemento > 0) {
			if (GeraGrids.player) {
				Level1Script.scoresPlayer1 += 1;
			} else {
				Level1Script.scoresPlayer2 += 1;
			}

			GeraGrids.quantElemento [elemento] = GeraGrids.quantElemento [elemento] - 1;

			if (GeraGrids.quantElemento [elemento] == 0) {
				if (GeraGrids.player) {
					Debug.Log ("Aqui aparece um questionário para o player 1");
					TestOption ();
				} else {
					Debug.Log ("Aqui aparece um questionário para o player 2");
					TestOption ();
				}

			}
		}			

		terminou = true;
		for (i = 0; i < GeraGrids.quantElemento.Length; i++)
			if (GeraGrids.quantElemento [i] != 0)
				terminou = false;
		
		if (terminou)
			SceneManager.LoadScene (3);
		


		GeraGrids.player = !GeraGrids.player; 
		Destroy (this.gameObject);
	
	}

	public void SetTemElemento (int el)
	{
		elemento = el;
	}

	void Awake () {
		modalPanel = ModalPanel.Instance ();
		displayManager = DisplayManager.Instance ();

		myOp1Action = new UnityAction (TestOp1Function);
		myOp1Action = new UnityAction (TestOp2Function);
		myOp1Action = new UnityAction (TestOp3Function);
		myOp1Action = new UnityAction (TestOp4Function);
		myOp1Action = new UnityAction (TestOp5Function);
	}

	//  Send to the Modal Panel to set up the Buttons and Functions to call
	public void TestOption () {
		Debug.Log ("teste");	
		modalPanel.Choice ("Qual o nome do elemento encontrado?", TestOp1Function, TestOp2Function, TestOp3Function, TestOp4Function, TestOp5Function);
		//      modalPanel.Choice ("Would you like a poke in the eye?\nHow about with a sharp stick?", myYesAction, myNoAction, myCancelAction);
	}

	//  These are wrapped into UnityActions
	void TestOp1Function () {
		displayManager.DisplayMessage ("Voce clicou na opção 1!");
	}

	void TestOp2Function () {
		displayManager.DisplayMessage ("Voce clicou na opção 2!");
	}

	void TestOp3Function () {
		displayManager.DisplayMessage ("Voce clicou na opção 3!");
	}

	void TestOp4Function () {
		displayManager.DisplayMessage ("Voce clicou na opção 4!");
	}

	void TestOp5Function () {
		displayManager.DisplayMessage ("Voce clicou na opção 5!");
	}
		
}
