using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chaveHud : MonoBehaviour {

	public Image chaveAmarela;
	public Image chaveAzul;

	void Start ()
	{
		chaveAmarela.enabled = false;
		chaveAzul.enabled = false;
	}


	void Update ()
	{
		if (Input.GetKeyDown ("f")) {
			chaveAmarela.enabled = true;
		} else if(Input.GetKeyDown ("g")) {
			chaveAzul.enabled = true;

		}

	}



}
