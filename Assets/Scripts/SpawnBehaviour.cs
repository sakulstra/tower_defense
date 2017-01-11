using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour {
    private float timeout = 3;
    private float timer;
    public GameObject enemy1;
	// Use this for initialization
	void Start () {
        timer = timeout;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeout;
            GameObject go = (GameObject)Instantiate(enemy1);
        }
    }
}
