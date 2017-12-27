using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 背景创建 : MonoBehaviour
{

	public GameObject _Prefab;
	Vector3 _中心位置;
	public int _个数 = 5;
	public float _半径 = 10;
	public Vector3 _左上随机坐标组;
	public Vector3 _右下随机坐标组;

	public void 创建物体 ()
	{
		transform.position = new Vector3 (Random.Range (_左上随机坐标组.x, _右下随机坐标组.x), Random.Range (_右下随机坐标组.y, _左上随机坐标组.y), _左上随机坐标组.z);
		_中心位置 = transform.position;
		GameObject[] newObj = new GameObject[_个数];
		for (int i = 0; i < _个数; i++) {
			newObj [i] = Instantiate (_Prefab) as GameObject;
			Vector3 movement = new Vector3 (_半径 * Mathf.Cos (2 * Mathf.PI * i / _个数), _半径 * Mathf.Sin (2 * Mathf.PI * i / _个数), 0);
			newObj [i].transform.position = _中心位置 + movement / 100;
			newObj [i].SetActive (true);
		}
		//newObj.transform.SetParent(_Parent);

	}
}
