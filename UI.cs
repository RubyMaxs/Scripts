using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    static UI singleton;
    public GameObject panel;
    public Text panelScoreText;
    public Text defeatText;
    public Text victoryText;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Player.score.ToString();
    }
    private void Awake()
    {
        singleton = this;
    }
    public static void ShowVictoryPanel()
    {
        singleton.panel.SetActive(true);
        singleton.victoryText.gameObject.SetActive(true);
        singleton.panelScoreText.text = Player.score.ToString();
    }
    public static void ShowDefeatPanel()
    {
        singleton.panel.SetActive(true);
        singleton.defeatText.gameObject.SetActive(true);
        singleton.panelScoreText.text = Player.score.ToString();
    }
    public void OnClickRestart()
    {
        Player.Restart();
        Player.score = 0;
    }
}
