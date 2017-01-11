using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public int playernumber = 1;

    private float running;
    private float defaultSpeed = 3.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float speed = this.defaultSpeed;
        Vector3 newPos = new Vector3(
            speed * Time.deltaTime * Input.GetAxis("Horizontal_" + this.playernumber),
            0,
            speed * Time.deltaTime * Input.GetAxis("Vertical_" + this.playernumber)
        );
        transform.position += newPos;
    }
}