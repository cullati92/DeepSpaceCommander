using UnityEngine;
using System.Collections;

public class asteroidDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y < -18){
			this.Destroy(gameObject);
		}
	}
}
