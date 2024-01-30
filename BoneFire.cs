using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneFire : MonoBehaviour
{
    public float lifeTimer = 15.0f;
    public float warmPower = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTimer -= Time.deltaTime;
        if(lifeTimer <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            Temperature temp = other.GetComponent<Temperature>();
            if(temp.correntTemp < temp.maxTemp)
            {
                temp.correntTemp += warmPower * Time.deltaTime;
            }
        }
    }
}
