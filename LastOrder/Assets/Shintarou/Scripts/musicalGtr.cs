//----------------------------------------------
//            	   Koreographer                 
//    Copyright © 2014-2016 Sonic Bloom, LLC    
//----------------------------------------------

using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu ("Koreographer/Demos/Musical Impulse")]
	public class musicalGtr : MonoBehaviour
	{
		[EventID]
		public string eventID;
		public GameObject note;
		public float testScale = 3.5f;

		void Start ()
		{
			// Register for Koreography Events.  This sets up the callback.
			Koreographer.Instance.RegisterForEvents (eventID, AddImpulse);
		}

		void OnDestroy ()
		{
			if (Koreographer.Instance != null) {
				Koreographer.Instance.UnregisterForAllEvents (this);
			}
		}

		void AddImpulse (KoreographyEvent evt)
		{
			Vector2 r = Random.insideUnitCircle.normalized * testScale;
			float ranNum = Random.Range (1.0f, 2.0f);
			Instantiate (note, new Vector3 (r.x * ranNum, r.y / ranNum, 0), Quaternion.identity);
		}
	}
}
