﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class clickCardScript : MonoBehaviour
{
	private ModalPanel modalPanel;
	private DisplayManager displayManager;
	private BringToFront bringToFront;

	static UnityAction myOp1Action;
	static UnityAction myOp2Action;
	static UnityAction myOp3Action;
	static UnityAction myOp4Action;
	static UnityAction myOp5Action;

	private string vezDoJogador;

	private int elemento;
	public static int i;
	public static bool terminou;

	// Use this for initialization
	void Start ()
	{
//		displayManager.DisplayMessage ("Vez do Jogador 1");
	}

	// Update is called once per frame
	void Update ()
	{
        
	}

	void OnMouseDown ()
	{		
		
		if (elemento > 0) {
            AudioScript.PlaySound("acerto");
            AumentaScore (1);

			GeraGrids.quantElemento [elemento] = GeraGrids.quantElemento [elemento] - 1;

			if (GeraGrids.quantElemento [elemento] == 0) {
                AudioScript.PlaySound("questionario");
                if (GeraGrids.player) {					
					TestOption ();
					//para retornar ao player que acertou
					//changePlayer();
				} else {
					TestOption ();
					//para retornar ao player que acertou
					//changePlayer();
				}
			} else {           
                changePlayer ();
			}
		} else {
            AudioScript.PlaySound("erro");
            changePlayer ();
		}

		Destroy (this.gameObject);
	}

	public static void changePlayer ()
	{
		GeraGrids.player = !GeraGrids.player;
	/*	if (GeraGrids.player) {
//			displayManager.DisplayMessage ("Vez do Jogador 1");
		} else {
//			displayManager.DisplayMessage ("Vez do Jogador 2");
		}*/
	}

	public static void verificaCompletou ()
	{

		terminou = true;
		for (i = 0; i < GeraGrids.quantElemento.Length; i++)
			if (GeraGrids.quantElemento [i] != 0)
				terminou = false;

		if (terminou)
			SceneManager.LoadScene (GeraGrids.qualCena);
		
	}

	public void SetTemElemento (int el)
	{
		elemento = el;
	}

	public static void AumentaScore (int quant)
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
//		displayManager = DisplayManager.Instance ();

/*		myOp1Action = new UnityAction (TestOp1Function);
		myOp2Action = new UnityAction (TestOp2Function);
		myOp3Action = new UnityAction (TestOp3Function);
		myOp4Action = new UnityAction (TestOp4Function);
		myOp5Action = new UnityAction (TestOp5Function);*/
	}


	//  Send to the Modal Panel to set up the Buttons and Functions to call
	public void TestOption ()
	{
		GeraGrids.blocks.gameObject.SetActive (false);

		vezDoJogador = " Vez do Jogador 2";
		if (GeraGrids.player)
			vezDoJogador = " Vez do Jogador 1";
      
        modalPanel.Choice ("\n Qual o nome do elemento encontrado?", elemento - 1);
	}


		
				
}
