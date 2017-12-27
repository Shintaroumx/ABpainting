using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 闭合模式 : MonoBehaviour {

    // Use this for initialization
    // Use this for initialization
    public 量存储 new量存储;
    Vector3 _中心位置;
    public Vector3 _坐标偏差;
    public float _远离速度 = 10;
    public float _旋转速度 = 1;
    public float _半径 = 10;
    float _相位;
    float 触发时间;
    void Start()
    {
        _中心位置 = new量存储._中心位置;
        触发时间 = Time.realtimeSinceStartup;
        _相位 = Mathf.Atan2(transform.position.y - _中心位置.y , transform.position.x - _中心位置.x );
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newmovement = new Vector3(0, 0, 0);
        newmovement.x = _半径 * Mathf.Cos(_旋转速度 * (Time.realtimeSinceStartup - 触发时间) + _相位);
        newmovement.y = _半径 * Mathf.Sin(_旋转速度 * (Time.realtimeSinceStartup - 触发时间) + _相位);
        transform.position = newmovement / 100 +  _中心位置 ;
        Vector3 _方向 = (transform.position - _中心位置 ).normalized;
        transform.position = transform.position - _方向 * _远离速度 * (Time.realtimeSinceStartup - 触发时间) / 100;
    }
}
