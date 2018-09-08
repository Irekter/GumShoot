using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    
    public float speed = 5;

    public float livetime = 5;
    private bool isliving;
	void Update () {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(livetime>=0)
        {
            livetime -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.collider.gameObject);
        }
    }

}
