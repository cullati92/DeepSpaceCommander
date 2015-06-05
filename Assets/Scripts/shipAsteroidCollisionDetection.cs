using UnityEngine;
using System.Collections;

public class shipAsteroidCollisionDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		print ("Loaded level: " + Application.loadedLevel + "\n");
		print ("Other: " + other.gameObject.name + "\n");
		if (other.gameObject.name.Equals("asteroid1"))
			Application.LoadLevel(0);
	}
}
