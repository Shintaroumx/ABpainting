using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCtrl : MonoBehaviour
{

	public GameObject note;
	public GameObject circle;
	public GameObject AfterEffect;
	public GameObject brush;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (1) && circle.transform.localScale.x < 1.4) {
			Destroy (note.gameObject, 0);
			Instantiate (AfterEffect, note.transform.position, Quaternion.identity);
			Instantiate (brush, note.transform.position, Quaternion.identity);
		}
		if (Input.GetMouseButtonDown (1) && circle.transform.localScale.x > 1.5)
			GameObject.Find ("HP").GetComponent<hP> ().HpDamage ();
	}
}
