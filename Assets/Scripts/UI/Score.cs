﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    public int currentScore =0;
    public int maxScore =4;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text = GameObject.Find("ScoreTextViewer").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = currentScore + "/" + maxScore;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Science")
        {
            text.text = "Correct!";
        }
        else if (other.gameObject.tag == "Player")
        {
            text.text = "Seriously, adding yourself?";
        }
        else
        {
            print("Sorry, wrong block");
            text.text = "Sorry wrong block";
        }
    }
}
