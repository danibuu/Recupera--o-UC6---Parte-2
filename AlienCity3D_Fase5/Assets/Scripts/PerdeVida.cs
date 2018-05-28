using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerdeVida : MonoBehaviour {

	public float vida;


	void OnCollisionEnter(Collision col)
	{
		if(col.transform.tag=="dano")
		{
			vida -= 10;
		}
	}
}
