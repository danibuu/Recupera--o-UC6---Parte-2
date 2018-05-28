using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColetarItens : MonoBehaviour {

	public Text pontuacao;
	private int pontos;

	// Use this for initialization
	void Start () {
		pontos = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "pedra")
		{
			other.gameObject.SetActive (false);
			pontos = pontos + 1;
			pontuacao.text = "Pontos: " + pontos;
		}

	}
}
