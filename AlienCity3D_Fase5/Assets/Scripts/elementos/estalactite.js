function Start()
{

}

function Update()
{
	if(identificarPersonagem.personagemProximo == true)
	{
		transform.parent = null;
		transform.GetComponent.<Rigidbody>().bodyType = Rigidbody.Dynamic;
	}
}