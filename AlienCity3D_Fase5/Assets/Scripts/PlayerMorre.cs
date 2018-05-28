using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMorre : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//se vc colidir vai morrer
	void OnCollisionEnter (Collision Colisao){
		if(Colisao.gameObject.tag == "obstaculo"){
			Destroy (Colisao.gameObject);
		}
	}
}
