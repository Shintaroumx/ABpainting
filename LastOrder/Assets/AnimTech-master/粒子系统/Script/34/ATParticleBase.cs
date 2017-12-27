using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class ATParticleBase : MonoBehaviour
{
	public float _ForcePower = 1.0f;
	public float _ForceOffset = 1.0f;
	public float _LifeSpan = 10.0f;

	public AnimationCurve ac;
	public float playSpeed = 1.0f;
	float timeOffset = 0.0f;
	Vector3 sca;

	// Use this for initialization
	void Start ()
	{
		sca = transform.localScale;
		timeOffset = Random.value;
	}
	
	// Update is called once per frame
	public virtual void Update ()
	{
		LifePassThenDie ();
		ApplyRandomForce ();
		SizeonLifetime ();

	}

	void LifePassThenDie ()
	{
		_LifeSpan -= Time.deltaTime;
		if (_LifeSpan < 0.0f) {
			Destroy (gameObject);
		}
	}

	void ApplyRandomForce ()
	{
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddForceAtPosition (_ForcePower * Random.insideUnitCircle, _ForceOffset * Random.insideUnitCircle);
	}

	void SizeonLifetime ()
	{
		timeOffset += Time.deltaTime;
		float tens = ac.Evaluate (timeOffset * playSpeed);
		transform.localScale = new Vector3 (sca.x * tens, sca.y * tens, sca.z);
	}

}
