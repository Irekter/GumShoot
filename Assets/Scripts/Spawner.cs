using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Enemy_one eone;
    public Spiral spy;

    float maxtime = 3;
    public float spawntime_one = 3f;
    public float spiraltime = 5f;
    public Transform[] spawnpoints;
    public Transform[] spiralpoints;


    public int spiralpointindex;


    // Use this for initialization
    void Start () {
        //InvokeRepeating("Spawn", spawntime_one, spawntime_one);
	}
	
	// Update is called once per frame
	void Update () {
        if(spawntime_one>=0)
        {
            spawntime_one -= Time.deltaTime;
        }
        else
        {
            StartCoroutine("Wait1Spawn");
            spawntime_one = maxtime;
        }
        if (spiraltime >= 0)
        {
            spiraltime -= Time.deltaTime;
        }
        else
        {
            StartCoroutine("Wait2Spawn");
            spiraltime = maxtime;
        }
        
    }

    IEnumerator Wait1Spawn()
    {
        yield return new WaitForSeconds(3.0f);
        int spawnpointindex = Random.Range(0, spawnpoints.Length);
        Enemy_one e =Instantiate(eone, spawnpoints[0].position, spawnpoints[0].rotation) as Enemy_one;
        //yield return new WaitForSeconds(1.0f);
    }

    IEnumerator Wait2Spawn()
    {
        yield return new WaitForSeconds(4.0f);
        spiralpointindex = Random.Range(0, spiralpoints.Length);
        Spiral sp = Instantiate(spy, spiralpoints[spiralpointindex].position, spiralpoints[spiralpointindex].rotation) as Spiral;
    }
}
