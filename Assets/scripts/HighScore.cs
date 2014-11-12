using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	static public int	score = 1000;

	void Awake() {
		//If the ApplePickerHighScore already exists, read it
		if(PlayerPrefs.HasKey ("ApplePickerHighScore")){
			score = getHighScore();
		}

		//Assign the HighScore to ApplePickerHighScore
		setHighScore ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GUIText gt = this.GetComponent<GUIText>();
		gt.text = "High Score: " + score;

		//Update ApplePickerHighScore in PlayerPrefs if neccessary
		if(score > getHighScore()){
			setHighScore ();
		}
	}

	int getHighScore(){
		return PlayerPrefs.GetInt("ApplePickerHighScore");
	}

	void setHighScore(){
		PlayerPrefs.SetInt ("ApplePickerHighScore", score);
	}
}
