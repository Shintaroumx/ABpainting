using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneManager : MonoBehaviour
{

	// Use this for initialization
	public void loadMenu ()
	{
		Application.LoadLevel ("Menu");
	}

	public void Quit ()
	{
		Application.Quit ();
	}

	public void Reload ()
	{
		Application.LoadLevel ("Demo");
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	public void GameOver ()
	{
		Application.LoadLevel ("GameOve");
	}
}
