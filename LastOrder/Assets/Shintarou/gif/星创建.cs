using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 星创建 : MonoBehaviour {

    // Use this for initialization
    public GameObject _Prefab;
    public Transform _小人位置;
    public int _个数 = 1;
    public void 创建()
    {
        GameObject[] newObj = new GameObject[_个数];
        for (int i = 0; i < _个数; i++)
        {
            newObj[i] = Instantiate(_Prefab) as GameObject;
            newObj[i].transform.position = _小人位置.position;
            newObj[i].SetActive(true);
        }
    }

}
