using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 小人 : MonoBehaviour
{

	// Use this for initialization
	Rigidbody2D rb;
	public float spd = 1.0f;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = Random.insideUnitCircle * spd;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	private void OnTriggerEnter2D (Collider2D collision)
	{

		if (collision.gameObject.name == "Cube") {
			rb.velocity = new Vector2 (rb.velocity.x, -rb.velocity.y);

		}
		if (collision.gameObject.name == "Cube (1)") {
			rb.velocity = new Vector2 (-rb.velocity.x, rb.velocity.y);

		}
		if (collision.gameObject.name == "Cube (2)") {
			rb.velocity = new Vector2 (-rb.velocity.x, rb.velocity.y);

		}
		if (collision.gameObject.name == "Cube (3)") {
			rb.velocity = new Vector2 (rb.velocity.x, -rb.velocity.y);

		}
	}

}
