using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 星裂 : MonoBehaviour {
    public Transform _出现位置;
    public GameObject _Prefab;
    public int _min=1,_max=5;
	// Use this for initialization
	public void 创建()
    {
        int num = Random.Range(_min, _max);
        for(int i=0;i<num;i++)
        {
            GameObject newobj = Instantiate(_Prefab) as GameObject;
            newobj.transform.position = _出现位置.position;
            newobj.SetActive(true);
        }
        
    }
}
