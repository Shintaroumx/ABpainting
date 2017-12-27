using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 裂星模式 : MonoBehaviour
{

	// Use this for initialization
	public Vector3 offset;
	public float _ForcePosDist = 1.0f;
	public float _ForceScale = 0.5f;
	Vector2 _Force;
	Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		_Force = Random.insideUnitCircle.normalized;
		rb.velocity = _Force * _ForceScale;
	}
}
