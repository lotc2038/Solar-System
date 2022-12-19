using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at

	void Start() {
		if (target == null) 
		{
			target = this.gameObject;
		}
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {
		LookAtTarget.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
	}
}
