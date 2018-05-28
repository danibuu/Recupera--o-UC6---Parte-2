static var personagemProximo : boolean = false;

function Start()
{

}

function Update()
{

}
function OnTriggerEnter(Coll: Collider)
{
	if(Coll.gameObject.tag == "Player")
	{
		personagemProximo = true;
	}
}