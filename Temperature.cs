using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;
    public float maxTemp = 36.6f;
    public float correntTemp = 36.6f;
    public int playerTempDamage = 1;
    public float tempDown = 0.05f;
    public float criticalTemp = 29.0f;
    public float frezzeTimer = 1;
    public float frezzeTimerCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        correntTemp -= tempDown * Time.deltaTime;
        if(correntTemp <= criticalTemp)
        {
            if(frezzeTimer <= 0)
            {
                health.TakeDamage(playerTempDamage);
                frezzeTimer = frezzeTimerCount;
            }
            else
            {
                frezzeTimer -= Time.deltaTime;
            }
        }
    }
}
