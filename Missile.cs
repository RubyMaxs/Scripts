using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Enemy")
        {
            Enemy enemy = other.GetComponent<Enemy>();
            Destroy(enemy.gameObject);
            Destroy(gameObject);
        }

        Destroy(gameObject);
    }
}
