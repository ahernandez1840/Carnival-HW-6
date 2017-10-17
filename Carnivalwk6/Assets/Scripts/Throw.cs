using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    GameObject prefab;
    // Use this for initialization
    void Start()
    {

        prefab = Resources.Load("Baseball") as GameObject;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            GameObject Baseball = Instantiate(prefab) as GameObject;
            Baseball.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = Baseball.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;





        }




    }
}
