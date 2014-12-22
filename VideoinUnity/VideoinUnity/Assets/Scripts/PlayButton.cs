using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		if (GUI.Button (new Rect ((Screen.width / 2) - 75, (Screen.height / 2) - 50, 150, 100), "Play the movie")) 
		{
			Application.LoadLevel(1);

		}
	
	}
}
