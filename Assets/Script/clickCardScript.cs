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

	static UnityAction myOp1Action;
	static UnityAction myOp2Action;
	static UnityAction myOp3Action;
	static UnityAction myOp4Action;
	static UnityAction myOp5Action;

    private string vezDoJogador;

	private int i, elemento;
	private bool terminou;

	// Use this for initialization
	 void Start ()
	 {
        displayManager.DisplayMessage("Vez do Jogador 1");
     }

	// Update is called once per frame
	void Update ()
	{
        
    }

	void OnMouseDown ()
	{				
		if (elemento > 0) {

			AumentaScore (1);

			GeraGrids.quantElemento [elemento] = GeraGrids.quantElemento [elemento] - 1;

			if (GeraGrids.quantElemento [elemento] == 0) {
				if (GeraGrids.player) {
					Debug.Log ("Aqui aparece um questionário para o player 1");
					TestOption ();
                    //para retornar ao player que acertou
                    //changePlayer();
                } else {
					Debug.Log ("Aqui aparece um questionário para o player 2");
					TestOption ();
                    //para retornar ao player que acertou
                    //changePlayer();
                }
            }
            else
            {
                changePlayer();
            }
        }
        else
        {
            changePlayer();
        }

        Destroy (this.gameObject);
	}

    private void changePlayer()
    {
        GeraGrids.player = !GeraGrids.player;
        if (GeraGrids.player) {
            Debug.Log(1);
            displayManager.DisplayMessage("Vez do Jogador 1");
        }
        else {
            Debug.Log(2);
            displayManager.DisplayMessage("Vez do Jogador 2");
        }
    }

    void verificaCompletou ()
	{

		terminou = true;
		for (i = 0; i < GeraGrids.quantElemento.Length; i++)
			if (GeraGrids.quantElemento [i] != 0)
				terminou = false;

		if (terminou)
			SceneManager.LoadScene (3);
		
	}

	public void SetTemElemento (int el)
	{
		elemento = el;
	}

	void AumentaScore (int quant)
	{
		if (GeraGrids.player) {
			Level1Script.scoresPlayer1 += quant;
		} else {
			Level1Script.scoresPlayer2 += quant;
		}
	}

	void Awake ()
	{
		modalPanel = ModalPanel.Instance ();
		displayManager = DisplayManager.Instance ();

		myOp1Action = new UnityAction (TestOp1Function);
		myOp2Action = new UnityAction (TestOp2Function);
		myOp3Action = new UnityAction (TestOp3Function);
		myOp4Action = new UnityAction (TestOp4Function);
		myOp5Action = new UnityAction (TestOp5Function);
	}


	//  Send to the Modal Panel to set up the Buttons and Functions to call
	public void TestOption ()
	{
        vezDoJogador = " Vez do Jogador 2";
        if (GeraGrids.player)
            vezDoJogador = " Vez do Jogador 1";

        modalPanel.Choice ("\n" + vezDoJogador + "\n Qual o nome do elemento encontrado?", myOp1Action, myOp2Action, myOp3Action, myOp4Action, myOp5Action);
	}

	//  These are wrapped into UnityActions
	void TestOp1Function ()
	{
        changePlayer();
        RightOption (modalPanel.op1Button);
	}

	void TestOp2Function ()
	{
        changePlayer();
        RightOption (modalPanel.op2Button);
	}

	void TestOp3Function ()
	{
        changePlayer();
        RightOption (modalPanel.op3Button);
	}

	void TestOp4Function ()
	{
        changePlayer();
        RightOption (modalPanel.op4Button);
	}

	void TestOp5Function ()
	{
        changePlayer();
        RightOption (modalPanel.op5Button);
	}

	void RightOption (Button optionSelected)
	{
        if (optionSelected.GetComponentInChildren<Text> ().text == "Água") {
            changePlayer();
            AumentaScore (5);
			modalPanel.modalPanelObject.SetActive (false);
			displayManager.DisplayMessage ("Voce acertou!");			
			verificaCompletou ();
		} else {    
            modalPanel.question.text = "\n Vez do Jogador 2 \n Qual o nome do elemento encontrado?";
            if (GeraGrids.player)
                modalPanel.question.text = "\n Vez do Jogador 1 \n Qual o nome do elemento encontrado?";
          
            optionSelected.interactable = false;			
		}
			
	}
		
				
}
