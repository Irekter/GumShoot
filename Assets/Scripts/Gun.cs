using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public bool isFiring;

    public Bullet bullet;

    public float bulletSpeed;

    public float shottime;
    private float shotcounter;

    public Transform firepoint;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (isFiring)
            
    }

    public void Shoot()
    {
        //if (shottime >= 0)
        //{

        //    shottime -= Time.deltaTime;
        //}
        //else
        //{

            Bullet newbullet = Instantiate(bullet, firepoint.position, firepoint.rotation) as Bullet;
            newbullet.speed = bulletSpeed;
            //hottime = 1.0f;
        //}
    }
}

