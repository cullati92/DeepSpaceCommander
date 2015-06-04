using UnityEngine;
using System.Collections;

public class shipMovement : MonoBehaviour {

	Touch touch;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount == 1) {
			touch = Input.GetTouch(0);
			if (touch.position.x < Screen.width/2) {
				if (this.transform.position.x > -30)
				{
					float displacement = 30 + this.transform.position.x;
					if (displacement < 1)
					{
						transform.Translate(Vector3.left * displacement);
						return;
					}
					transform.Translate (Vector3.left * 1);
				}else if (this.transform.position.x == -30)
				{
					return;
				}
			} else if (touch.position.x > Screen.width/2) {
				if (this.transform.position.x < 30)
				{
					float displacement = 30 - this.transform.position.x;
					if(displacement < 1)
					{
						transform.Translate (Vector3.right * displacement);
						return;
					}
					transform.Translate (Vector3.right * 1);
				}else if (this.transform.position.x == 30)
				{
					return;
				}
			}
		}
	}
}
