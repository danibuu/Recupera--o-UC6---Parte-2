using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class colisorObjetos : MonoBehaviour {

	public GameObject porta;
	int contChave = 0;
	public Text TextoPortao;

	// Use this for initialization
	void Start () {
		contChave = GameObject.FindGameObjectsWithTag ("chave").Length;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void  OnTriggerEnter (Collider other){
		if  (other.gameObject.CompareTag ( "obstaculo")) {
			string currentScene = SceneManager.GetActiveScene ().name;
			SceneManager.LoadScene (currentScene);
		}
		if (other.gameObject.CompareTag("chave")) {
			contChave--;
			Destroy (other.gameObject);
			if (contChave == 0) {
				TextoPortao.gameObject.SetActive (true);
				porta.gameObject.SetActive (false);
			}
		}
	}
}
