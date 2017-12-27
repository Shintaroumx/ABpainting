using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 小人尺寸变化 : MonoBehaviour {
    public Vector3 _最大尺寸;
    public Vector3 _最小尺寸;
    public float _单次变化量;
    float _此次变化量;
    // Use this for initialization
    void Start () {
        _此次变化量 = _单次变化量;

    }
	
	// Update is called once per frame
	void Update () {
        if(transform.localScale.x> _最大尺寸.x)
        {
            _此次变化量 = -_单次变化量;
        }
        else if(transform.localScale.x< _最大尺寸.x)
        {
            _此次变化量 = _单次变化量;
        }
        transform.localScale = new Vector3(transform.localScale.x + _此次变化量, transform.localScale.y + _此次变化量, transform.localScale.z);
	}
}
