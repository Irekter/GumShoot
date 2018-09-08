using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : MonoBehaviour
{
    GameObject POINT;
    Spawner _spawner;

    public float speed;

    float width, lenth, timeCounter = 0;
    public GameObject player;
    void Start()
    {
        POINT = GameObject.Find("Spawner");
        _spawner = POINT.GetComponent<Spawner>();

        //Circle
        int number = Random.Range(0, 4);
        width = Vector3.Distance(player.transform.position, _spawner.spiralpoints[_spawner.spiralpointindex].position);
        lenth = Vector3.Distance(player.transform.position, _spawner.spiralpoints[_spawner.spiralpointindex].position);
        //Debug.Log(_spawner.spiralpoints[_spawner.spiralpointindex]);
    }

    void Update()
    {
        //MoveInTriangle();
        MoveInCircle();

    }

    private void MoveInCircle()
    {
        

        timeCounter += Time.deltaTime * speed;
        if (width > 0 && lenth > 0)
        {
            width = width - 0.01f;
            lenth = lenth - 0.01f;
        }

        float x = Mathf.Cos(timeCounter) * width;
        float y = 0;
        float z = Mathf.Sin(timeCounter) * lenth;
        transform.position = new Vector3(x, y, z);
    }


}
