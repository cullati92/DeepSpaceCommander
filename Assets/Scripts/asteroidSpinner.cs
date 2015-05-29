using UnityEngine;
using System.Collections;

public class asteroidSpinner : MonoBehaviour {

	Vector3 torque = new Vector3(0,0,Random.Range(-200,200));

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (torque * Time.deltaTime);
	}
}
