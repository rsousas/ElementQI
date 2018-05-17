using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;



public class clickCardScript : MonoBehaviour
{

	public int i, elemento;

	private ModalPanel modalPanel;
	private DisplayManager displayManager;

	private UnityAction myYesAction;
	private UnityAction myNoAction;
	private UnityAction myCancelAction;

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
			Level1Script.scores += 1;
			GeraGrids.quantElemento [elemento] = GeraGrids.quantElemento [elemento] - 1;

			if (GeraGrids.quantElemento [elemento] == 0)
				Debug.Log ("Aqui aparece um questionário");	
		}			

		terminou = true;
		for (i = 0; i < GeraGrids.quantElemento.Length; i++)
			if (GeraGrids.quantElemento [i] != 0)
				terminou = false;
		
		if (terminou)
			SceneManager.LoadScene (3);
		

		modalPanel = ModalPanel.Instance ();
		displayManager = DisplayManager.Instance ();

		myYesAction = new UnityAction (TestYesFunction);
		myNoAction = new UnityAction (TestNoFunction);
		myCancelAction = new UnityAction (TestCancelFunction);

		modalPanel.enabled = true;
		TestYNC ();

		Destroy (this.gameObject);
	
	}

	public void SetTemElemento (int el)
	{
		elemento = el;
	}
		



	//  Send to the Modal Panel to set up the Buttons and Functions to call
	public void TestYNC ()
	{
		modalPanel.Choice ("Do you want to spawn this sphere?", TestYesFunction, TestNoFunction, TestCancelFunction);
		//      modalPanel.Choice ("Would you like a poke in the eye?\nHow about with a sharp stick?", myYesAction, myNoAction, myCancelAction);
	}

	//  These are wrapped into UnityActions
	void TestYesFunction ()
	{
		displayManager.DisplayMessage ("Heck yeah! Yup!");
	}

	void TestNoFunction ()
	{
		displayManager.DisplayMessage ("No way, José!");
	}

	void TestCancelFunction ()
	{
		displayManager.DisplayMessage ("I give up!");
	}
}
