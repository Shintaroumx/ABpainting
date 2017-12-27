using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 创建 : MonoBehaviour {

    
    public GameObject _Prefab;
    public float _颜料深度 = 5.0f;
    public Transform _小人位置;
    Vector3 _中心位置;
    public Vector3 _坐标偏差;
    public int _个数=5;
    public float _半径=10;
    public void 创建物体()
    {
        transform.position = new Vector3(_小人位置.position.x, _小人位置.position.y, _小人位置.position.z);
        _中心位置 = transform.position;
        GameObject[] newObj=new GameObject[_个数];
        for (int i=0;i< _个数;i++)
        {
            newObj[i] = Instantiate(_Prefab) as GameObject;
            Vector3 movement = new Vector3(_半径 * Mathf.Cos(2*Mathf.PI*i/ _个数), _半径  * Mathf.Sin(2 * Mathf.PI * i / _个数), 0);
            newObj[i].transform.position = _中心位置+movement/100;
            newObj[i].SetActive(true);
        }
        //newObj.transform.SetParent(_Parent);

    }
}
