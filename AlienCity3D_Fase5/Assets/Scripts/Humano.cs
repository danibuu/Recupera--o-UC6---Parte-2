using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Humano : MonoBehaviour {

	public Image humano;
	public Image cabecaHumano1;
	public Image cabecaHumano2;
	public Image cabecaHumano3;


	void Start ()
	{
		humano.enabled = false;
		cabecaHumano1.enabled = false;
		cabecaHumano2.enabled = false;
		cabecaHumano3.enabled = false;

	}


	void Update ()
	{
		if (Input.GetKeyDown ("e")) {
			humano.enabled = true;
			cabecaHumano1.enabled = true;
			cabecaHumano2.enabled = true;
			cabecaHumano3.enabled = true;
		} 
	}
}
