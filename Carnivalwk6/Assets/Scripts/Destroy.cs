using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    
	// Use this for initialization
	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {
		
        



	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Cubez")
        {

            Destroy(col.gameObject); //destroy the gameobject that was collided with as stored in the collisionreport

        }
    }
}

