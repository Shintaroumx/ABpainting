using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class natureDestroy : MonoBehaviour
{
	// Use this for initialization
	public float lifeTime = 2.0f;
	public bool healthFlag = false;

	delegate void HPDMG ();

	HPDMG hpdmg;

	void Start ()
	{
		Destroy (this.gameObject, lifeTime);
		if (healthFlag) {
			hpdmg = GameObject.Find ("HP").GetComponent<hP> ().HpDamage;
			hpdmg ();
		}
	}
}
