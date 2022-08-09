using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;


    public float Xmax;
    public float Xmin;
    public float Ymax;
    public float Ymin;

    private float spawnTime;
    public float TimebtwSpawn;
    
    
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + TimebtwSpawn;
        }
        if(TimebtwSpawn > 0.40)
        {
            TimebtwSpawn = TimebtwSpawn - 0.005f * Time.deltaTime;
        }
        if (TimebtwSpawn < 0.40)
        {
            TimebtwSpawn = TimebtwSpawn - 0.001f * Time.deltaTime;
        }


    }

    void Spawn()
    {
        float RandomX = Random.Range(Xmin, Xmax);
        float RandomY = Random.Range(Ymin, Ymax);

        Instantiate(enemy, transform.position + new Vector3(RandomX, RandomY), transform.rotation );

    }
}
