using UnityEngine;
using System.Collections;

public class starField : MonoBehaviour {

	new bool isPlaying;
	public Rigidbody2D starPrefab;
	int x;
	int y;
	int delay;
	int[] randArray = new int[101];

	// Use this for initialization
	void Start () {
		isPlaying = true;
		y = 250;
	}
	
	// Update is called once per frame
	void Update () {
		if (delay < 0) {
			if (isPlaying == true) {
				delay = 16;
				x = UnityEngine.Random.Range (-51, 54);
				Object starClone;
				starClone = Instantiate (starPrefab, new Vector2 (x, y), new Quaternion (0, 0, 0, 0));
			}
		} 
		else {
			delay--;
			print(delay);
		}
	}
}
