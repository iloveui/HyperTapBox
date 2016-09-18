using UnityEngine;
using System.Collections;

public class TouchBox : MonoBehaviour {

	int i;

	void Start () {
	
	}
	

	void Update ()
	{
		foreach (Touch touch in Input.touches) 
		{
			if (touch.phase == TouchPhase.Began) {
				i++;
				Debug.Log (i);
			}
		}
	}
}
