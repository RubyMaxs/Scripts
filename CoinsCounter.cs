using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    public int coins = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CollectCoins()
    {
        coins++;
        print("Количество монет равно " + coins);
    }
}
