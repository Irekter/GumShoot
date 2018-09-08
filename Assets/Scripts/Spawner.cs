using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Enemy_one eone;
    float maxtime = 5;
    public float spawntime_one = 3f;
    public Transform[] spawnpoints;

	// Use this for initialization
	void Start () {
        //InvokeRepeating("Spawn", spawntime_one, spawntime_one);
	}
	
	// Update is called once per frame
	void Update () {
        if (spawntime_one >= 0)
        {
            
            spawntime_one -= Time.deltaTime;
        }
        else
        {
            StartCoroutine("WaitSpawn");
            spawntime_one = maxtime;
        }
    }

    IEnumerator WaitSpawn()
    {
        yield return new WaitForSeconds(3.0f);
        int spawnpointindex = Random.Range(0, spawnpoints.Length);
        Enemy_one e =Instantiate(eone, spawnpoints[0].position, spawnpoints[0].rotation) as Enemy_one;
        yield return new WaitForSeconds(1.0f);
    }
}
