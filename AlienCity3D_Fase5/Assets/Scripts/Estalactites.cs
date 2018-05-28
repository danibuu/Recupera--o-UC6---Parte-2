using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estalactites : MonoBehaviour {

	Rigidbody rgbd;
	bool tocaper = false;

	void Start()
	{
		rgbd = GetComponent<Rigidbody>();
		rgbd.useGravity = false;
	}

	void Update()
	{

		tocaper = Physics.Raycast(transform.position,-Vector3.up,9.5f);


		if (tocaper)
		{
			rgbd.useGravity = true;

		}

	}

}
