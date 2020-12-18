using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TagObject : MonoBehaviour
{
    public Text text;
    public Score score;
    public int tries;
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        score = GetComponent<Score>();
        score = GameObject.Find("ScoreTextViewer").GetComponent<Score>();
        text = GameObject.Find("MainTextViewer").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Science")
        {
            text.text = "Correct!";
            wall.SetActive(true);
            score.currentScore++;
        }
        else if (other.gameObject.tag == "Player")
        {
            text.text = "Seriously, adding yourself?";
        }
        else
        {
            print("Sorry, wrong block");
            text.text = "Sorry wrong block";
            tries++;
            if (tries > 4)
            {
                text.text = "Seriously, I'm begging you to add the block please?";
            }
        }
    }
}

