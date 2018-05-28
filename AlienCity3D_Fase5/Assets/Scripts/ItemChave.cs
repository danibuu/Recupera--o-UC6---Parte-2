using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class ItemChave : MonoBehaviour {

	public int IDDestaChave = 0;
	[Range(0.1f,10.0f)] public float distanciaDaChave = 3;
	public KeyCode TeclaPegar1 = KeyCode.F;
	public KeyCode TeclaPegar2 = KeyCode.G;
	public AudioClip somPegarChave;
	AudioSource emissorDeSom;
	GameObject Jogador;
	Chaves _listaDeChaves;
	bool jaPegou;

	void Start(){
		jaPegou = false;
		Jogador = GameObject.FindWithTag ("Player");
		if (Jogador != null) {
			_listaDeChaves = Jogador.GetComponent<Chaves> ();
		}
		emissorDeSom = GetComponent<AudioSource> ();
		emissorDeSom.playOnAwake = false;
		emissorDeSom.loop = false;
	}

	void Update(){
		if (Jogador != null && _listaDeChaves != null) {
			if (jaPegou == false) {
				float distancia = Vector3.Distance (Jogador.transform.position, transform.position);
				if (distancia < distanciaDaChave) {
					if (Input.GetKeyDown (TeclaPegar1)) {
						_listaDeChaves.ChavesDoJogador.Add (IDDestaChave);
						jaPegou = true;
						StartCoroutine ("DestruirObjeto");
					}else if(Input.GetKeyDown (TeclaPegar2)){
						_listaDeChaves.ChavesDoJogador.Add (IDDestaChave);
						jaPegou = true;
						StartCoroutine ("DestruirObjeto");
					}
				}
			}
		}
	}

	IEnumerator DestruirObjeto(){
		MeshRenderer renderer = GetComponentInChildren <MeshRenderer> ();
		if (renderer != null) {
			renderer.enabled = false;
		}
		if (somPegarChave != null) {
			emissorDeSom.clip = somPegarChave;
			emissorDeSom.PlayOneShot (emissorDeSom.clip);
		}
		yield return new WaitForSeconds (3);
		Destroy (gameObject);
	}
}