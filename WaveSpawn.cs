using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{
    public static int EnemiesAlive = 0;
    public Transform enemie;

    public Transform enemie2;

    public Transform enemie3;

    public Transform SpawnPoint;

    public Transform SpawnPoint2;

    public Transform SpawnPoint3;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private int waveNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveNumber++;

        for (int i = 0; i < waveNumber ; i++)
        {
            SpawnEnemie();
            yield return new WaitForSeconds(0.5f);
        }
        
    }

    void SpawnEnemie()
    {
        Instantiate(enemie, SpawnPoint.position, SpawnPoint.rotation);
        Instantiate(enemie2, SpawnPoint2.position, SpawnPoint2.rotation);
        Instantiate(enemie3, SpawnPoint3.position, SpawnPoint3.rotation);

    }
}
