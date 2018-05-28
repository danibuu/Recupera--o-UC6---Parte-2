using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Morrer : MonoBehaviour {
	public string cena;

	void OnTriggerEnter(){
		SceneManager.LoadScene (cena);
	}



}
