using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
	static public generator lm;
	//public Transform player;
	public GameObject note;
	public float testScale = 3.5f;

	public float rateTime = 2.0f;
	float countTime;
	// Use this for initialization
	void Awake ()
	{
		lm = this;
	}
	
	// Update is called once per frame
	void Update ()
	{
		countTime += Time.deltaTime;
		if (countTime > rateTime) {
			Vector2 r = Random.insideUnitCircle.normalized * testScale;
			float ranNum = Random.Range (1.0f, 2.0f);
			Instantiate (note, new Vector3 (r.x * ranNum, r.y / ranNum, 0), Quaternion.identity);
			countTime -= rateTime;
		}
	}
}
