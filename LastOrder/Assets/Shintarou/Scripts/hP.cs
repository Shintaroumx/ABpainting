using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hP : MonoBehaviour
{
	public Slider HPStrip;
	public int HP = 10;
	public GameObject panel;

	void Start ()
	{  
		HPStrip.maxValue = HP;
		HPStrip.value = HPStrip.maxValue; 
	}

	public void HpDamage ()
	{  
		HP -= 2;
		HPStrip.value = HP;
		if (HP <= 0) {  
			GameObject.Find ("SceneManager").GetComponent<sceneManager> ().GameOver ();
		}  
	}

	public void Healing ()
	{
		if (HP <= 10) {
			HP += 1;
			HPStrip.value = HP;
		}
	}
}
