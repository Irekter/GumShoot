using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_one : MonoBehaviour {

    public float enemyonespeed = 3;

    //Enemy_one newone;

    GameObject POINT;
    Spawner _spawner;

	// Use this for initialization
	void Start ()
    {
        POINT = GameObject.Find("Spawner");
        _spawner = POINT.GetComponent<Spawner>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Transform target = _spawner.spawnpoints[1];
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * enemyonespeed);
    }
}
