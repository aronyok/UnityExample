using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
public class PlayVideo : MonoBehaviour {

	public MovieTexture movie;
	//public Texture2D backGround;

	// Use this for initialization
	void Start () {

		renderer.material.mainTexture = movie as MovieTexture; 
		audio.clip = movie.audioClip;
		movie.Play ();
		audio.Play ();
	}

	void OnMouseDown(){

		movie.Stop ();
		Application.LoadLevel ("PlayButton");
	}

	void Update(){

		if (!movie.isPlaying)
			Application.LoadLevel ("PlayButton");
	}
	
}