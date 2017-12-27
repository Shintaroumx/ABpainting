using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LCtrl : MonoBehaviour
{
	public GameObject note;
	public GameObject circle;
	public GameObject AfterEffect;
	public GameObject miss;
	
	// Update is called once per frame
	void Update ()
	{
		
		Collider2D[] col = Physics2D.OverlapPointAll (Camera.main.ScreenToWorldPoint (Input.mousePosition));

		if (col.Length > 0) {
			foreach (Collider2D c in col) {
				//do what you want
				if (Input.GetMouseButtonDown (0) && circle.transform.localScale.x < 1.5) {
					Destroy (note.gameObject, 0);
					Instantiate (AfterEffect, note.transform.position, Quaternion.identity);
					GameObject.Find ("HP").GetComponent<hP> ().Healing ();
				}
				if (Input.GetMouseButtonDown (0) && circle.transform.localScale.x >= 1.5) {
					Instantiate (miss, note.transform.position, Quaternion.identity);
					Destroy (note.gameObject, 0);
					GameObject.Find ("HP").GetComponent<hP> ().HpDamage ();
				} 
			}
		} else {
			Invoke ("NoteDes", 1.0f);
		}
					
	}

	void NoteDes ()
	{
		Destroy (note.gameObject, 0);
		Instantiate (miss, note.transform.position, Quaternion.identity);
		GameObject.Find ("HP").GetComponent<hP> ().HpDamage ();
	}
}
