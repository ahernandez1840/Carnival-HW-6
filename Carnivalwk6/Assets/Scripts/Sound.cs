using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

	AudioSource myAudio;
	public AudioClip boomSound;
    public AudioClip thump;
    public AudioClip magic;
    public AudioClip bg;

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource> ();
        myAudio.PlayOneShot(bg);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		Debug.Log ("ya done collid'd");
		myAudio.PlayOneShot(thump, 0.1F); //play the boom sound upon any collision

		if (col.gameObject.name == "Plane") { //check the collisionReport to see if the GameObject collided with was tagged with "spherez"
			myAudio.PlayOneShot(boomSound, 0.1F); //if so, play the sphereCollide audioclip
		}
	}
}