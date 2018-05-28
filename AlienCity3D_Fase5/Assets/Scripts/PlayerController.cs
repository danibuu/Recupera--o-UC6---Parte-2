using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

	public float MoveSpeed;
	public float RotationSpeed;
	CharacterController cc;
	private Animator anim;
	protected Vector3 gravidade = Vector3.zero;
	protected Vector3 move = Vector3.zero;
	private bool jump = false;


	
	void Start()
	{
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator>();
		anim.SetTrigger("Parado");
	}

	void Update()
	{
		Vector3 move = Input.GetAxis ("Vertical") * transform.TransformDirection (Vector3.forward) * MoveSpeed;
		transform.Rotate (new Vector3 (0, Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime, 0));
		//se o personagem não estiver tocando o solo
		if (!cc.isGrounded) {
			gravidade += Physics.gravity * Time.deltaTime;
		} 
		else 
		{
			//se o personagem estiver sobre alguma superficie, a gravidade e e zerada
			gravidade = Vector3.zero;
			if(jump)
			{
				//se o pers esta pulando a gravidade assume o valor de 6f
				gravidade.y = 6f;
				//desliga o pulo para poder pular de novo quando tocar o solo
				jump = false;
			}
		}
		move += gravidade;
		cc.Move (move* Time.deltaTime);
		//metodo anima é responsavel pelo controle das animações
		Anima ();
	}
	 
	void Anima()
	{
		//se nenhuma tecla esta sendo precionada
		if (!Input.anyKey)
		{
			//chmar a animação de parado.
			anim.SetTrigger("Parado");
		} 
		else 
		{
			//senao verifica se esta sendo precionado a tecla espaço
			if(Input.GetKeyDown("space"))
			{
				//chamar a animação do pulo
				anim.SetTrigger("Pula");
				jump = true;
			}
			else
			{
				//caso contrario chamar a animação da corrida
				anim.SetTrigger("Corre");
			}
		}
	}
}
