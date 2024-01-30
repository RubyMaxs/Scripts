using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Timer : MonoBehaviour
{
    public string sceneName;
    public int min = 10;
    public float sec = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sec -= Time.deltaTime;
        if (min <= 0 & sec <= 0)
        {
            EditorSceneManager.LoadScene(sceneName);
        }
        else if (sec <= 0)
        {
            min -= 1;
            sec += 60;
        }
    }
}
