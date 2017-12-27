using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AT止速 : MonoBehaviour {

	// Use this for initialization
	
    public void _止速()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,0);
    }
}
