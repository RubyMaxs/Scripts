using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Health : MonoBehaviour
{
    public string sceneName;
    public int health = 10;
    public int maxHealth = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(health <= 0)
        {
            EditorSceneManager.LoadScene(sceneName);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрок: " + health);
    }
}
