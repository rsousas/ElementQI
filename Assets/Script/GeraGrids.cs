using UnityEngine;
using System.Collections;

public class GeraGrids : MonoBehaviour
{

    private int posX, posY;
	private int i;

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
	public GameObject ObjetoElemento;

	public int tamX;
	public int tamY;
	public int quantElemento;

    public ushort[,] Map = new ushort[30, 15];

    // Use this for initialization
    void Start()
    {
		posIniX = tamX * posIniX;
		posIniY = tamY * posIniY;
        gerarGrid();
        geraFundoErro();
		geraFundoElemento();
        geraCard();
    }

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left mouse clicked");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                Debug.Log("Active piece: " + hit.transform.gameObject.name.ToString());

                if (hit.transform.tag == "error")
                    Debug.Log("Errou");

                if (hit.transform.tag == "card")
                {
                    Destroy(hit.transform.gameObject);
                    Debug.Log("Card");
                }
            }
        }*/
    }

  /*  void gerarGrid()
    {
        for (posX = 0; posX < 30; posX++)
        {
            for (posY = 0; posY < 15; posY++)
            {
                Map[posX, posY] = 1;
            }
        }

        for (posX = 0; posX < 13; posX++)
            Map[posX, 0] = 0;

        for (posX = 0; posX < 12; posX++)
            Map[posX, 1] = 0;

        for (posX = 0; posX < 11; posX++)
            Map[posX, 2] = 0;

        for (posX = 0; posX < 10; posX++)
            Map[posX, 3] = 0;

        Map[27, 0] = Map[28, 0] = Map[29, 0] = Map[28, 1] = Map[29, 1] = Map[29, 2] = 0;
        Map[0, 4] = Map[1, 4] = Map[2, 4] = Map[0, 5] = Map[1, 5] = Map[0, 6] = 0;
        Map[27, 10] = Map[28, 10] = Map[28, 9] = Map[29, 10] = Map[29, 9] = Map[29, 8] = 0;
        Map[0, 12] = Map[0, 13] = Map[0, 14] = Map[1, 13] = Map[1, 14] = Map[2, 14] = 0;

        for (posX = 20; posX < 30; posX++)
            Map[posX, 11] = 0;

        for (posX = 19; posX < 30; posX++)
            Map[posX, 12] = 0;

        for (posX = 18; posX < 30; posX++)
            Map[posX, 13] = 0;

        for (posX = 17; posX < 30; posX++)
            Map[posX, 14] = 0;

        for (posX = 0; posX < 30; posX++)
        {
            for (posY = 0; posY < 15; posY++)
            {
                if (Map[posX, posY] == 1)
                    Instantiate(ObjetoGrid, new Vector3(posX * 0.6f - 8.75f, posY * 0.6f - 3.25f, 0), Quaternion.identity);
            }
        }
    }

    void geraFundoErro()
    {
        for (posX = 0; posX < 30; posX++)
        {
            for (posY = 0; posY < 15; posY++)
            {
                if (Map[posX, posY] == 1)
                    Instantiate(ObjetoErro, new Vector3(posX * 0.6f - 8.75f, posY * 0.6f - 3.25f, -0.01f), Quaternion.identity);
            }
        }
    }

    void geraCard()
    {
        for (posX = 0; posX < 30; posX++)
        {
            for (posY = 0; posY < 15; posY++)
            {
                if (Map[posX, posY] == 1)
					Instantiate(ObjetoCard, new Vector3(posX * 0.6f - 8.75f, posY * 0.6f - 3.25f, -0.02f), Quaternion.identity);				
            }
        }
    } */

	void gerarGrid()
	{
		for (posX = 0; posX < tamX; posX++)
		{
			for (posY = 0; posY < tamY; posY++)
			{
				Map[posX, posY] = 1;
			}
		}

		if ((tamX > 19) && (tamY > 14) ) {
			// 
			for (posX = 0; posX < Mathf.Round (tamX * 0.433f); posX++)
				Map [posX, 0] = 0;

			for (posX = 0; posX < Mathf.Round (tamX * 0.4f); posX++)
				Map [posX, 1] = 0;

			for (posX = 0; posX < Mathf.Round (tamX * 0.366f); posX++)
				Map [posX, 2] = 0;

			for (posX = 0; posX < Mathf.Round (tamX * 0.333f); posX++)
				Map [posX, 3] = 0;

			//
			for (posX = (int)Mathf.Round (tamX * 0.9f); posX < tamX; posX++)
				Map [posX, 0] = 0;

			for (posX = (int)Mathf.Round (tamX * 0.933f); posX < tamX; posX++)
				Map [posX, 1] = 0;

			for (posX = (int)Mathf.Round (tamX * 0.966f); posX < tamX; posX++)
				Map [posX, 2] = 0;

			// Map[27, 0] = Map[28, 0] = Map[29, 0] = 0;
			//			  Map[28, 1] = Map[29, 1] = 0;
			//						   Map[29, 2] = 0;

			//
			for (posX = 0; posX < Mathf.Round (tamX * 0.1f); posX++)
				Map [posX, 4] = 0;

			for (posX = 0; posX < Mathf.Round (tamX * 0.066f); posX++)
				Map [posX, 5] = 0;

			for (posX = 0; posX < Mathf.Round (tamX * 0.033f); posX++)
				Map [posX, 6] = 0;
			
			// Map[0, 4] = Map[1, 4] = Map[2, 4] = 0;
			// Map[0, 5] = Map[1, 5] = 0;
			// Map[0, 6] = 0;
	
			//
			for (posX = (int)Mathf.Round (tamX * 0.966f); posX < tamX; posX++)
				Map [posX, 8] = 0;

			for (posX = (int)Mathf.Round (tamX * 0.933f); posX < tamX; posX++)
				Map [posX, 9] = 0;

			for (posX = (int)Mathf.Round (tamX * 0.9f); posX < tamX; posX++)
				Map [posX, 10] = 0;

			//							  Map[29, 8] = 0;
			//				 Map[28, 9] = Map[29, 9] = 0;
			// Map[27, 10] = Map[28, 10] =  Map[29, 10] = 0;

			//
			for (posX = 0; posX < Mathf.Round (tamX * 0.033f); posX++)
				Map [posX, 12] = 0;

			for (posX = 0; posX < Mathf.Round (tamX * 0.066f); posX++)
				Map [posX, 13] = 0;

			for (posX = 0; posX < Mathf.Round (tamX * 0.1f); posX++)
				Map [posX, 14] = 0;
			
			// Map[0, 12] = 0;
			// Map[0, 13] = Map[1, 13] = 0;
			// Map[0, 14] = Map[1, 14] = Map[2, 14] = 0;

			for (posX = (int)Mathf.Round (tamX * 0.666f); posX < tamX; posX++)
				Map [posX, 11] = 0;

			for (posX = (int)Mathf.Round (tamX * 0.633f); posX < tamX; posX++)
				Map [posX, 12] = 0;

			for (posX = (int)Mathf.Round (tamX * 0.6f); posX < tamX; posX++)
				Map [posX, 13] = 0;

			for (posX = (int)Mathf.Round (tamX * 0.566f); posX < tamX; posX++)
				Map [posX, 14] = 0;
		}


		// Mapeia o Elemento
		for (i = 0; i < quantElemento; i++)
			for (posX = 5; posX < 8; posX++)
				Map [posX, 5] = 2;


		for (posX = 0; posX < tamX; posX++)
		{
			for (posY = 0; posY < tamY; posY++)
			{
				if (Map[posX, posY] != 0)
				Instantiate(ObjetoGrid, new Vector3(posX * 0.6f - posIniX, posY * 0.6f - posIniY, 0), Quaternion.identity);
			}
		}
	}

	void geraFundoErro()
	{
		for (posX = 0; posX < tamX; posX++)
		{
			for (posY = 0; posY < tamY; posY++)
			{
				if (Map[posX, posY] == 1)
					Instantiate(ObjetoErro, new Vector3(posX * 0.6f - posIniX, posY * 0.6f - posIniY, -0.01f), Quaternion.identity);
			}
		}
	}
	void geraFundoElemento()
	{
		for (posX = 0; posX < tamX; posX++)
		{
			for (posY = 0; posY < tamY; posY++)
			{
				if (Map[posX, posY] > 1)
					Instantiate(ObjetoElemento, new Vector3(posX * 0.6f - posIniX, posY * 0.6f - posIniY, -0.01f), Quaternion.identity);
			}
		}		
	}

	void geraCard()
	{
		for (posX = 0; posX < tamX; posX++)
		{
			for (posY = 0; posY < tamY; posY++)
			{
				if (Map[posX, posY] != 0)
					obj = (Instantiate(ObjetoCard, new Vector3(posX * 0.6f - posIniX, posY * 0.6f - posIniY, -0.02f), Quaternion.identity)) as GameObject;	
				if (Map[posX, posY] > 1)		
					obj.GetComponent<clickCardScript>().Teste();
			}
		}
	}
}
