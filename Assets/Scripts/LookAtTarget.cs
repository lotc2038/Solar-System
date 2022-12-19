using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour {

	static public GameObject target;

	void Start () {
		if (target == null) 
		{
			target = this.gameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (target)
			transform.LookAt(target.transform);
	}
}
