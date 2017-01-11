using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkBehaviour : MonoBehaviour {

    public float speed = 3.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(
            speed * Time.deltaTime * Random.Range(-1.0f, 1.0f),
            0,
            speed * Time.deltaTime * Random.Range(-1.0f, 1.0f)
        );
    }
}
