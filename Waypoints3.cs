using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints3 : MonoBehaviour
{
    public static Transform[] points3;

    // Start is called before the first frame update
    void Awake()
    {
        points3 = new Transform[transform.childCount];
        for (int i = 0; i < points3.Length; i++)
        {
            points3[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
