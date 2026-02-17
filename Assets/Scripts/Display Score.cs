using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    //gets the score value from the goal
    public GoalZone goalZone;
    //needed to hook up the text to itself
    public TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Just garentees that the text updates from frame 1
        scoreText.text = "Score: " + "0";
    }

    // Update is called once per frame
    void Update()
    {
        //basic code that sets the text to Score: + whaterver the current score is
        scoreText.text = "Score: " + goalZone.score.ToString();
    }
}
