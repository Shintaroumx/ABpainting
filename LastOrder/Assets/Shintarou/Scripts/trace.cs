using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trace : MonoBehaviour
{

	public ATTraceRecorder _Recorder;
	int id = 0;
	// Use this for initialization

	// Update is called once per frame
	void Update ()
	{
		if (id < _Recorder._Trace.Count) {
			transform.position = _Recorder._Trace [id].Pos;
			id++;
		}

	}
}
