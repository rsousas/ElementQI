using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

//  This script will be updated in Part 2 of this 2 part series.
public class ModalPanel : MonoBehaviour {

	public Text question;
	public Image iconImage;
	public int element;

	public Button op1Button;
	public Button op2Button;
	public Button op3Button;
	public Button op4Button;
	public Button op5Button;

	public GameObject modalPanelObject;

	private static ModalPanel modalPanel;

	public static ModalPanel Instance () {
		if (!modalPanel) {
			modalPanel = FindObjectOfType(typeof (ModalPanel)) as ModalPanel;
			if (!modalPanel)
				Debug.LogError ("There needs to be one active ModalPanel script on a GameObject in your scene.");
		}

		return modalPanel;
	}

	// Options 1-5: A string, a options 1-5 events
	public void Choice (string question, int elemento, UnityAction op1Event, UnityAction op2Event, UnityAction op3Event, UnityAction op4Event, UnityAction op5Event) {
		element = elemento;

		modalPanelObject.SetActive (true);
	
		op1Button.onClick.RemoveAllListeners();
		op1Button.onClick.AddListener (op1Event);
		op1Button.onClick.AddListener (ClosePanel);

		op2Button.onClick.RemoveAllListeners();
		op2Button.onClick.AddListener (op2Event);
		op2Button.onClick.AddListener (ClosePanel);

		op3Button.onClick.RemoveAllListeners();
		op3Button.onClick.AddListener (op3Event);
		op3Button.onClick.AddListener (ClosePanel);

		op4Button.onClick.RemoveAllListeners();
		op4Button.onClick.AddListener (op4Event);
		op4Button.onClick.AddListener (ClosePanel);

		op5Button.onClick.RemoveAllListeners();
		op5Button.onClick.AddListener (op5Event);
		op5Button.onClick.AddListener (ClosePanel);

		this.question.text = question;

		this.op4Button.GetComponentInChildren<Text> ().text = GeraGrids.respostaCerta[elemento];

        this.iconImage.gameObject.SetActive (true);
		op1Button.gameObject.SetActive (true);
		op2Button.gameObject.SetActive (true);
		op3Button.gameObject.SetActive (true);
		op4Button.gameObject.SetActive (true);
		op5Button.gameObject.SetActive (true);
	}

	void ClosePanel () {
		//modalPanelObject.SetActive (false);
	}

}