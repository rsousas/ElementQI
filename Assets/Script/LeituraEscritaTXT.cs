using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LeituraEscritaTXT : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string linha;
		Debug.Log (Application.dataPath);
		StreamReader sr = new StreamReader(Application.dataPath + "/ArquivoParaLeitura.txt"); //pode ser *.ini
		StreamWriter sw = new StreamWriter(Application.dataPath + "/ArquivoParaEscrita.txt"); //pode ser *.ini

		linha = sr.ReadLine();
		if (linha == string.Empty) {
			linha = "A primeira linha do Arquivo de Leitura estava vazia.";
		}

		sw.WriteLine("Minha primeira Gravacao no Arquivo.");
		sw.WriteLine("");
		sw.WriteLine("Linha copiada do outro arquivo: " + linha);

		sr.Close(); // fecha o arquivo, para o SO poder usá-lo para outras coisas
		sw.Close(); // fecha o arquivo, para o SO poder usá-lo para outras coisas
		Debug.Log("Pronto!");		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
