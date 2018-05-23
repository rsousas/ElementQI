using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

//  This script will be updated in Part 2 of this 2 part series.
public class ModalPanel : MonoBehaviour
{

	public Text question;
	public Image iconImage;
	public int element;
	[HideInInspector]

	public Button op1Button;
	public Button op2Button;
	public Button op3Button;
	public Button op4Button;
	public Button op5Button;

	public GameObject modalPanelObject;
	public GameObject canvasObject;

	private static ModalPanel modalPanel;

	public static ModalPanel Instance ()
	{
		if (!modalPanel) {
			modalPanel = FindObjectOfType (typeof(ModalPanel)) as ModalPanel;
			if (!modalPanel)
				Debug.LogError ("There needs to be one active ModalPanel script on a GameObject in your scene.");
		}

		return modalPanel;
	}

	// Options 1-5: A string, a options 1-5 events
	public void Choice (string question, int elemento)
	{
		element = elemento;

		canvasObject.SetActive (true);
		modalPanelObject.SetActive (true);
	
		op1Button.onClick.RemoveAllListeners ();
		op1Button.onClick.AddListener (TestOp1Function);

		op2Button.onClick.RemoveAllListeners ();
		op2Button.onClick.AddListener (TestOp2Function);

		op3Button.onClick.RemoveAllListeners ();
		op3Button.onClick.AddListener (TestOp3Function);

		op4Button.onClick.RemoveAllListeners ();
		op4Button.onClick.AddListener (TestOp4Function);

		op5Button.onClick.RemoveAllListeners ();
		op5Button.onClick.AddListener (TestOp5Function);

		this.iconImage.gameObject.GetComponent<Image> ().sprite = GeraGrids.imagemElemento [elemento];
		this.question.text = question;
		this.op4Button.GetComponentInChildren<Text> ().text = GeraGrids.respostaCerta [elemento];

		this.iconImage.gameObject.SetActive (true);
		op1Button.gameObject.SetActive (true);
		op2Button.gameObject.SetActive (true);
		op3Button.gameObject.SetActive (true);
		op4Button.gameObject.SetActive (true);
		op5Button.gameObject.SetActive (true);	

		op1Button.interactable = true;
		op2Button.interactable = true;
		op3Button.interactable = true;
		op4Button.interactable = true;
		op5Button.interactable = true;
	}


	//  These are wrapped into UnityActions
	void TestOp1Function ()
	{
		
		RightOption (modalPanel.op1Button);
	}

	void TestOp2Function ()
	{
		
		RightOption (modalPanel.op2Button);
	}

	void TestOp3Function ()
	{
		
		RightOption (modalPanel.op3Button);
	}

	void TestOp4Function ()
	{
		
		RightOption (modalPanel.op4Button);
	}

	void TestOp5Function ()
	{		
		
		RightOption (modalPanel.op5Button);
	}

	void RightOption (Button optionSelected)
	{


		if (optionSelected.GetComponentInChildren<Text> ().text == GeraGrids.respostaCerta [modalPanel.element]) {
			AudioScript.PlaySound("acerto");
			AudioScript.PlaySound("aplausos");
			clickCardScript.AumentaScore (5);
			modalPanelObject.SetActive (false);
			canvasObject.SetActive (false);
			GeraGrids.blocks.gameObject.SetActive (true);
			//			displayManager.DisplayMessage ("Voce acertou!");			
			clickCardScript.verificaCompletou ();

		} else {    
			AudioScript.PlaySound("erro");

			//optionSelected.gameObject.SetActive (false);
			optionSelected.interactable = false;	

		}
		clickCardScript.changePlayer ();

	}

}