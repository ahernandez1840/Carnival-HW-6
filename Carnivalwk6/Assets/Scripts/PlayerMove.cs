using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public GameObject Player;
    public int movementAmt = 1;


    // Use this for initialization
    void Start () {



		
		
	}
	
	// Update is called once per frame
	void Update () {


        if(Input.GetKeyDown("up")) {
            Debug.Log("up arrow pressed down");
            Player.transform.position += new Vector3(-movementAmt, 0, 0);
        }
        if (Input.GetKeyDown("down"))
        {
            Debug.Log("right arrow pressed down");
            Player.transform.position += new Vector3(movementAmt, 0, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            Debug.Log("up arrow pressed down");
            Player.transform.position += new Vector3(0, 0, movementAmt);
        }
        if (Input.GetKeyDown("left"))
        {
            Debug.Log("down arrow pressed down");
            Player.transform.position += new Vector3(0, 0, -movementAmt);
        }
    }
}
