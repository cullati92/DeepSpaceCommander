using UnityEngine;
using System.Collections;

public class asteroidGenerator : MonoBehaviour {

	new bool isPlaying;
	public Rigidbody2D asteroidPrefab;
	int x;
	int y;
	int asteroidDelay = 1000;

	// Use this for initialization
	void Start () {
		isPlaying = true;
		y = 250;
	}
	
	// Update is called once per frame
	void Update () {
		if (asteroidDelay < 0) {
			if (isPlaying == true) {
				asteroidDelay = Random.Range (300, 600);
				x = UnityEngine.Random.Range (-44, 44);
				Object asteroidClone;
				asteroidClone = Instantiate (asteroidPrefab, new Vector2 (x, y), new Quaternion (0, 0, 0, 0));

			}
		} 
		else {
			asteroidDelay--;
		}
	}
}
