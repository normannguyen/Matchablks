using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public Text text;
    public int currentScore =0;
    public int maxScore =4;
    public GameObject teleporters;
    public GameObject teleportSpawn;
    public GameObject exitPortal;
    public GameObject exitSpawn;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        text = GetComponent<Text>();
        text = GameObject.Find("MainTextViewer").GetComponent<Text>();
        score = GameObject.Find("ScoreTextViewer").GetComponent<Text>();
        teleporters.SetActive(false);
        teleportSpawn.SetActive(false);
        exitPortal.SetActive(false);
        exitSpawn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = currentScore + "/" + maxScore;
        if(currentScore >= maxScore)
        {
            teleporters.SetActive(true);
            teleportSpawn.SetActive(true);
            currentScore = 0;
        }
        
    }
}
