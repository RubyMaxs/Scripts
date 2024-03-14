using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Laser projectilePrefab;
    public int points;
    public Transform shootPoint;
    public float shootSpeedMax = 0.2f;
    public float shootSpeedFactor = 0.05f;
    public float shootInterval = 0.5f;
    public float shootTimer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shootTimer -= Time.deltaTime;
        if(shootInterval >= shootSpeedMax)
        {
            shootInterval -= shootSpeedFactor * Time.deltaTime;
        }
        Shoot();
        Move();

    }
    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
        
    }
    void Shoot()
    {
        if(shootTimer <= 0)
        {
            Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            shootTimer = shootInterval;
        }
        
    }
}
