using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 裂星_体积持续减小 : MonoBehaviour {

    // Use this for initialization
    public float _减小系数 = 1.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = transform.localScale * 1.0f;
	}
}
