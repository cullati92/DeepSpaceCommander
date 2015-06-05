using UnityEngine;
using System.Collections;

public class starField : MonoBehaviour {

	new bool isPlaying;
	public Rigidbody2D starPrefab;
	int x;
	int y;
	int starDelay;

	// Use this for initialization
	void Start () {
		isPlaying = true;
		y = 190;
	}
	
	// Update is called once per frame
	void Update () {
		if (starDelay < 0) {
			if (isPlaying == true) {
				starDelay = 30;
				x = UnityEngine.Random.Range (-44, 44);
				Object starClone;
				starClone = Instantiate (starPrefab, new Vector3 (x, y, 2), new Quaternion (0, 0, 0, 0));
			}
		} 
		else {
			starDelay--;
		}
	}
}
