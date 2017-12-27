using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorTrail : MonoBehaviour
{

	// Use this for initialization
	public GameObject trail;
	public float distance = 0;
	public float movSpd = 100f;

	Vector3 mousePosition, targetPosition;

	void Start ()
	{
		mousePosition = Input.mousePosition;
		targetPosition = Camera.main.ScreenToWorldPoint (new Vector3 (mousePosition.x + 10, mousePosition.y - 25, distance));
		trail.transform.position = targetPosition;
		Instantiate (trail, trail.transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update ()
	{
		mousePosition = Input.mousePosition;
		targetPosition = Camera.main.ScreenToWorldPoint (new Vector3 (mousePosition.x + 10, mousePosition.y - 25, distance));
		Vector2 dir = targetPosition - trail.transform.position;
		trail.transform.Translate (dir * Time.deltaTime * movSpd);
	}
}
