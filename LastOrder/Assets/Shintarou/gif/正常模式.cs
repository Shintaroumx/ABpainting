using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 正常模式 : MonoBehaviour {

    // Use this for initialization
    public Transform _小人位置;
    Vector3 _中心位置;
    public Vector3 _坐标偏差;
    public float _旋转速度 = 1;
    public float _半径 = 10;
    float _相位;
    float 触发时间;
    void Start()
    {
        _中心位置 = new Vector3(_小人位置.position.x, _小人位置.position.y, _小人位置.position.z);
        触发时间 = Time.realtimeSinceStartup;
        _相位 = Mathf.Atan2(transform.position.y - _中心位置.y  , transform.position.x - _中心位置.x  );
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newmovement = new Vector3(0, 0, 0);
        newmovement.x = _半径 * Mathf.Cos(_旋转速度 * (Time.realtimeSinceStartup - 触发时间) + _相位);
        newmovement.y = _半径 * Mathf.Sin(_旋转速度 * (Time.realtimeSinceStartup - 触发时间) + _相位);
        this.GetComponent<Transform>().position = newmovement / 100  + _中心位置 ;
    }
}
