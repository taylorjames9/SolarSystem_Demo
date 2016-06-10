using UnityEngine;
using System.Collections;

public class OscillateWeight : MonoBehaviour {


	ForceField myForceField;
	float myForce;

	// Use this for initialization
	void Start () {
		myForceField = GetComponent<ForceField> ();
	}
	

	IEnumerator Oscillate( ){



		yield return new WaitForSeconds (1.0f);
		yield return StartCoroutine (Oscillate ());
	}


}
