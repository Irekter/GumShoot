using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Camera mainCam;

    public Gun gunn;


    // Use this for initialization
    void Start()
    {






    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane groundplane = new Plane(Vector3.up, Vector3.zero);
        float raylength;

        if(groundplane.Raycast(ray, out raylength))
        {
            Vector3 pointtolook = ray.GetPoint(raylength);
            transform.LookAt(new Vector3(pointtolook.x,transform.position.y,pointtolook.z));
        }


        if (Input.GetMouseButtonDown(0))
        {
            gunn.isFiring = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            gunn.isFiring = false;
        }
    }
}
