using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform bRight;
    public Transform bLeft;
    public float spawnIntr;
    public float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            Spawn();
        }
    }
    void Spawn()
    {
        float randomX = Random.Range(bLeft.position.x, bRight.position.x);
        Vector2 newPosition = transform.position;
        newPosition.x = randomX;
        Instantiate(prefab, newPosition, Quaternion.identity);
        spawnTimer = spawnIntr;
    }
}
