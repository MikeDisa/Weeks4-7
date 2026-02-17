using UnityEngine;

public class GoalZone : MonoBehaviour
{
    public SpriteRenderer goalSprite;
    public Transform football;

    public int score;
    private bool scoredThisKick;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (football == null || goalSprite == null) return;

        
        //Vector2 footballPos = football.position;
        //bool inside = goalSprite.bounds.Contains(footballPos);

        Vector3 p = football.position;
        p.z = goalSprite.bounds.center.z;
        bool inside = goalSprite.bounds.Contains(p);


        
        if (inside && !scoredThisKick)
        {
            score++;
            scoredThisKick = true;
            Debug.Log("Score: " + score);
        }

        
        if (!inside)
            scoredThisKick = false;

        Debug.Log($"football null? {football == null}, goalSprite null? {goalSprite == null}");
        if (football != null && goalSprite != null)
            Debug.Log($"football pos {football.position} bounds {goalSprite.bounds}");
    }
}

