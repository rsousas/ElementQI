using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

//  This script will be updated in Part 2 of this 2 part series.
public class TestModalWindow : MonoBehaviour {
	private ModalPanel modalPanel;
	private DisplayManager displayManager;

	private UnityAction myOp1Action;
	private UnityAction myOp2Action;
	private UnityAction myOp3Action;
	private UnityAction myOp4Action;
	private UnityAction myOp5Action;

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