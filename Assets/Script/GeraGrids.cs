using UnityEngine;
using System.Collections;

public class GeraGrids : MonoBehaviour {

	private int posX, posY;

	private float MapaJogadorX = -8;
	private float MapaJogadorY = -3;

	private float MapaAdversarioX = 1;
	private float MapaAdversarioY = -3;

	private float MapaX;
	private float MapaY;

	public GameObject ObjetoFundo;
	public GameObject ObjetoGrid;

	// Use this for initialization
	void Start () {
		for (posX = -10; posX <=10 ; posX++)
			for (posY =-5; posY <=5; posY++)
				Instantiate(ObjetoFundo, new Vector3(posX, posY, 0), Quaternion.identity);

		MapaX = MapaJogadorX;
		MapaY = MapaJogadorY;
		for (posX = 1; posX <=33 ; posX++)
		{	for (posY =1; posY <=15; posY++)
			{	
				Instantiate(ObjetoGrid, new Vector3(MapaX, MapaY, -1), Quaternion.identity);
				MapaY = MapaY + 0.5f;
			}
			MapaY = MapaJogadorY;
			MapaX = MapaX + 0.5f;
		}

	/*	
	    MapaX = MapaAdversarioX;
		MapaY = MapaAdversarioY;
		for (posX = 1; posX <=15 ; posX++)
		{	for (posY =1; posY <=15; posY++)
			{	
				Instantiate(ObjetoGrid, new Vector3(MapaX, MapaY, -1), Quaternion.identity);
				MapaY = MapaY + 0.5f;
			}
			MapaY = MapaAdversarioY;
			MapaX = MapaX + 0.5f;
		}*/
	}
}
