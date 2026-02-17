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
        //protects from null values skipping stuff
        if (football == null || goalSprite == null) return;

        //I tried this set up first but it didn't work, something about the ball spawning in the wrong z position.
        //Vector2 footballPos = football.position;
        //bool inside = goalSprite.bounds.Contains(footballPos);

        //Needed this stuff to set up a pseudo collider, needed a vector 3 so that I can change the Z in 2D.
        Vector3 p = football.position;
        p.z = goalSprite.bounds.center.z;
        bool inside = goalSprite.bounds.Contains(p);


        //The boolean makes it only go off once per collision and not every frame
        if (inside && !scoredThisKick)
        {
            //Score goes up when football colides with hidden object in field goal posts
            score++;
            scoredThisKick = true;
            Debug.Log("Score: " + score);
        }

        //resets the once per colision bool
        if (!inside)
            scoredThisKick = false;

        //bit of debug code that helped identify a z misalignment
        //Debug.Log($"football null? {football == null}, goalSprite null? {goalSprite == null}");
        //if (football != null && goalSprite != null)
        //    Debug.Log($"football pos {football.position} bounds {goalSprite.bounds}");
    }
}

