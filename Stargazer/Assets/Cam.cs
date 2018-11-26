using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		var ver = Input.GetAxis("Vertical");
		this.transform.Translate(Vector3.forward * Time.deltaTime * ver * 10);
		var hor = Input.GetAxis("Horizontal");
		this.transform.Translate(Vector3.right * Time.deltaTime * hor * 10);
	}
}
