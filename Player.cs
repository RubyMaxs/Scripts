using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static List<Square> squares;
    public static int score = 0;
    // Start is called before the first frame update
    void Awake()
    {
        squares = new List<Square>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(squares.Count == 0)
        {
            Victory();
        }
    }
    public static void Defeat()
    {
        UI.ShowDefeatPanel();
        score = 0;
    }
    public static void Victory()
    {
        UI.ShowVictoryPanel();
    }
    public static void Restart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
