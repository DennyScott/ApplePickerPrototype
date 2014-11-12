using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {
	public static float bottomY = -20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		destroyApple();
	}

	void destroyApple() {
		if(transform.position.y < bottomY){
			Destroy(this.gameObject);
		}
	}
}
