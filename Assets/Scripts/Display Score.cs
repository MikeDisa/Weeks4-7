using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    public GoalZone goalZone;

    public TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "Score: " + "0";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + goalZone.score.ToString();
    }
}
