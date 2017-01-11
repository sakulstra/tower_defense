using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public float speed = 3.0f;
    public int playernumber = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(
            speed * Time.deltaTime * Input.GetAxis("Horizontal" + playernumber),
            0,
            speed * Time.deltaTime * Input.GetAxis("Vertical" + playernumber)
        );
    }
}