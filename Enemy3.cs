using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public float speed = 10f;

    private Transform target3;
    private int wavePointIndex3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        target3 = Waypoints3.points3[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target3.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target3.position) <= 0.4f)
        {
            getNextWaypoint();
        }
    }

    void getNextWaypoint()
    {
        if (wavePointIndex3 >= Waypoints3.points3.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavePointIndex3++;
        target3 = Waypoints3.points3[wavePointIndex3];
    }
}
