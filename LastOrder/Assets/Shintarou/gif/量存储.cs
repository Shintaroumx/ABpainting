using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 量存储 : MonoBehaviour {
    public Transform _小人位置;
    public Vector3 _中心位置;
	// Use this for initialization
	void Start () {
        _中心位置 = new Vector3(_小人位置.position.x, _小人位置.position.y, _小人位置.position.z);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
