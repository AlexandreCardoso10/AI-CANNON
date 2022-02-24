using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float speed = 10f;

    private Transform target2;
    private int wavePointIndex2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        target2 = Waypoints2.points2[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target2.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target2.position) <= 0.4f)
        {
            getNextWaypoint();
        }
    }

    void getNextWaypoint()
    {
        if (wavePointIndex2 >= Waypoints2.points2.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavePointIndex2++;
        target2 = Waypoints2.points2[wavePointIndex2];
    }
}
