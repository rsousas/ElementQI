﻿using UnityEngine;
using System.Collections;

public class GeraGrids : MonoBehaviour
{

	private int posX, posY;
	private int i, j;

	private float MapaJogadorX = -8;
	private float MapaJogadorY = -3;

	private float MapaAdversarioX = 1;
	private float MapaAdversarioY = -3;

	private float MapaX, MapaY;
	private float posIniX = 0.2916f;
	private float posIniY = 0.1713f;

	private GameObject obj;

	public GameObject ObjetoGrid;
	public GameObject ObjetoErro;
	public GameObject ObjetoCard;
	public GameObject[] ObjetoElemento;

	public int tamX;
	public int tamY;
	public Vector4[] posElemento;
	// vetor.x e vetor.y: Posições do elemento na grade; vetor.z: Elemento completo a qual representa; vetor.w: Prefab que deve ser impresso (imagem)

	public Vector2[,] Map;
	// vetor.x: -1=Não imprime na posição, 0=Elemento Erro, 1+=Elemento acerto; vetor.y: Prefab que deve ser impresso (imagem)

	private Vector2[] MaiorElemento;
	// Até onde o primeiro elemento do elemento completo pode ser instanciado
	private Vector2[] PosRandElemento;

	// Possui a quantidade de elementos por elemento completo
	public static int[] quantElemento;

	//Manipula payer
	public static bool player = true;
	// Use this for initialization

	public static Transform blocks;

	public string[] respostasCerta;
	public static string[] respostaCerta;

	public Sprite[] imagensElemento;
	public static Sprite[] imagemElemento;

	public int qualCenas;
	public static int qualCena;

	void Start ()
	{
		Map = new Vector2[tamX, tamY];
		MaiorElemento = new Vector2[(int)posElemento [posElemento.Length - 1].z]; 
		PosRandElemento = new Vector2[(int)posElemento [posElemento.Length - 1].z];
		quantElemento = new int[(int)posElemento [posElemento.Length - 1].z + 1];
		respostaCerta = respostasCerta;
		imagemElemento = imagensElemento;
		qualCena = qualCenas;

		blocks = new GameObject ("Blocks").transform;
		blocks.transform.SetParent (this.transform);
		posIniX = tamX * posIniX;
		posIniY = tamY * posIniY;
		gerarGrid ();
		geraFundoErro ();
		geraFundoElemento (); 
		geraCard ();
	}

	void Update ()
	{
		
	}

	void gerarGrid ()
	{
		for (posX = 0; posX < tamX; posX++) {
			for (posY = 0; posY < tamY; posY++) {
				Map [posX, posY].Set (0, 0);
			}
		}

		if ((tamX > 19) && (tamY > 14)) {
			// 
			for (posX = 0; posX < Mathf.Round (tamX * 0.433f); posX++)
				Map [posX, 0].Set (-1, -1);

			for (posX = 0; posX < Mathf.Round (tamX * 0.4f); posX++)
				Map [posX, 1].Set (-1, -1);

			for (posX = 0; posX < Mathf.Round (tamX * 0.366f); posX++)
				Map [posX, 2].Set (-1, -1);

			for (posX = 0; posX < Mathf.Round (tamX * 0.333f); posX++)
				Map [posX, 3].Set (-1, -1);

			//
			for (posX = (int)Mathf.Round (tamX * 0.9f); posX < tamX; posX++)
				Map [posX, 0].Set (-1, -1);

			for (posX = (int)Mathf.Round (tamX * 0.933f); posX < tamX; posX++)
				Map [posX, 1].Set (-1, -1);

			for (posX = (int)Mathf.Round (tamX * 0.966f); posX < tamX; posX++)
				Map [posX, 2].Set (-1, -1);

			// Map[27, 0] = Map[28, 0] = Map[29, 0] = 0;
			//			  Map[28, 1] = Map[29, 1] = 0;
			//						   Map[29, 2] = 0;

			//
			for (posX = 0; posX < Mathf.Round (tamX * 0.1f); posX++)
				Map [posX, 4].Set (-1, -1);

			for (posX = 0; posX < Mathf.Round (tamX * 0.066f); posX++)
				Map [posX, 5].Set (-1, -1);

			for (posX = 0; posX < Mathf.Round (tamX * 0.033f); posX++)
				Map [posX, 6].Set (-1, -1);
			
			// Map[0, 4] = Map[1, 4] = Map[2, 4] = 0;
			// Map[0, 5] = Map[1, 5] = 0;
			// Map[0, 6] = 0;
	
			//
			for (posX = (int)Mathf.Round (tamX * 0.966f); posX < tamX; posX++)
				Map [posX, 8].Set (-1, -1);

			for (posX = (int)Mathf.Round (tamX * 0.933f); posX < tamX; posX++)
				Map [posX, 9].Set (-1, -1);

			for (posX = (int)Mathf.Round (tamX * 0.9f); posX < tamX; posX++)
				Map [posX, 10].Set (-1, -1);

			//							  Map[29, 8] = 0;
			//				 Map[28, 9] = Map[29, 9] = 0;
			// Map[27, 10] = Map[28, 10] =  Map[29, 10] = 0;

			//
			for (posX = 0; posX < Mathf.Round (tamX * 0.033f); posX++)
				Map [posX, 12].Set (-1, -1);

			for (posX = 0; posX < Mathf.Round (tamX * 0.066f); posX++)
				Map [posX, 13].Set (-1, -1);

			for (posX = 0; posX < Mathf.Round (tamX * 0.1f); posX++)
				Map [posX, 14].Set (-1, -1);
			
			// Map[0, 12] = 0;
			// Map[0, 13] = Map[1, 13] = 0;
			// Map[0, 14] = Map[1, 14] = Map[2, 14] = 0;

			for (posX = (int)Mathf.Round (tamX * 0.666f); posX < tamX; posX++)
				Map [posX, 11].Set (-1, -1);

			for (posX = (int)Mathf.Round (tamX * 0.633f); posX < tamX; posX++)
				Map [posX, 12].Set (-1, -1);

			for (posX = (int)Mathf.Round (tamX * 0.6f); posX < tamX; posX++)
				Map [posX, 13].Set (-1, -1);

			for (posX = (int)Mathf.Round (tamX * 0.566f); posX < tamX; posX++)
				Map [posX, 14].Set (-1, -1);
		}
			
		// Descobre maiores valores em x e y
		for (i = 0; i < posElemento.Length; i++) {
			if (MaiorElemento [(int)posElemento [i].z - 1].x < posElemento [i].x)
				MaiorElemento [(int)posElemento [i].z - 1].Set (posElemento [i].x, MaiorElemento [(int)posElemento [i].z - 1].y);
			
			if (MaiorElemento [(int)posElemento [i].z - 1].y < posElemento [i].y)
				MaiorElemento [(int)posElemento [i].z - 1].Set (MaiorElemento [(int)posElemento [i].z - 1].x, posElemento [i].y);
		}

		// Descobre posição aleatória inicial do elemento
		for (i = 0; i < MaiorElemento.Length; i++)
			PosRandElemento [i].Set (Random.Range (0, tamX - MaiorElemento [i].x), Random.Range (0, tamY - MaiorElemento [i].y));
		 


		// Mapeia o Elemento
		for (i = 0; i < posElemento.Length; i++)
			Map [((int)posElemento [i].x + (int)PosRandElemento [(int)posElemento [i].z - 1].x), ((int)posElemento [i].y + (int)PosRandElemento [(int)posElemento [i].z - 1].y)].Set ((int)posElemento [i].z, (int)posElemento [i].w);

		

		// Instancia a grade
		for (posX = 0; posX < tamX; posX++) {
			for (posY = 0; posY < tamY; posY++) {
				if (Map [posX, posY].x != -1) {
					GameObject blockTemporario = Instantiate (ObjetoGrid, new Vector3 (posX * 0.6f - posIniX, posY * 0.6f - posIniY, 0), Quaternion.identity) as GameObject;
					blockTemporario.transform.SetParent (blocks);
				}
			}
		}
	}

	// Instancia o fundo de erro
	void geraFundoErro ()
	{
		for (posX = 0; posX < tamX; posX++) {
			for (posY = 0; posY < tamY; posY++) {
				if (Map [posX, posY].x == 0) {
					GameObject blockTemporario = Instantiate (ObjetoErro, new Vector3 (posX * 0.6f - posIniX, posY * 0.6f - posIniY, -0.01f), Quaternion.identity) as GameObject;
					blockTemporario.transform.SetParent (blocks);
				}
			}
		}
	}

	// Instancia o fundo com elemento
	void geraFundoElemento ()
	{
		for (posX = 0; posX < tamX; posX++) {
			for (posY = 0; posY < tamY; posY++) {
				if (Map [posX, posY].x > 0) {
					GameObject blockTemporario = Instantiate (ObjetoElemento [(int)Map [posX, posY].y], new Vector3 (posX * 0.6f - posIniX, posY * 0.6f - posIniY, -0.01f), Quaternion.identity) as GameObject;
					blockTemporario.transform.SetParent (blocks);
				}
			}
		}		
	}

	// Instancia a frente com os cards de '?'
	void geraCard ()
	{
		for (posX = 0; posX < tamX; posX++) {
			for (posY = 0; posY < tamY; posY++) {
				if (Map [posX, posY].x != -1) {
					obj = (Instantiate (ObjetoCard, new Vector3 (posX * 0.6f - posIniX, posY * 0.6f - posIniY, -0.02f), Quaternion.identity)) as GameObject;
					obj.transform.SetParent (blocks);
				}
				if (Map [posX, posY].x > 0) {
					obj.GetComponent<clickCardScript> ().SetTemElemento ((int)Map [posX, posY].x);
					quantElemento [(int)Map [posX, posY].x] = quantElemento [(int)Map [posX, posY].x] + 1;
				}
			}
		}
	}
}
