
using UnityEngine;
using UnityEngine.UI;
// Manages the football parent object
public class FootballMover: MonoBehaviour
{
    public Slider PowerSlider;
    public MasterCoach MasterCoach;

    public Button LaunchButton;
    //distance and timer components for the lerp
    public float power;

    public float t = 0;

    //lerp set up variables
     Vector2 startPos;
     Vector2 endPos;
     
    //using a bool just helps make sure it keeps running
     public bool isKicking = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sets the lerp timer to 0 and sets lerp start to where the ball is
        t = 0f;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isKicking) return;

        t += Time.deltaTime;
        //once delta time hits 1 it all resets
        if (t >= 1f)
        {
            t = 0f;
            isKicking = false;
            
            //yet another null protector
            if (MasterCoach != null)
            {
                //calls for the football to respawn
                MasterCoach.Reset();
            }
       
            //self destruct button
            Destroy(gameObject);
        }

        //gotta love a lerp
        Vector2 pos = Vector2.Lerp(startPos, endPos, t);
        //apperently parabalas are just math so it turns a vector into an arc
        float arc = 4 * 5 * t * (1 - t);
        pos.y += arc;
        //combines the lerp and arc math to create an upward arcing path
        transform.position = pos;
    }

    

    //called by the UI button
    public void Kick()
    {
        //again sets start position to where the prefab spawns
        startPos = transform.position;
        //takes in the UI slider value
        float power = MasterCoach.PowerSlider.value;
        //modifies the end position x value to use the UI slider value
        endPos = startPos + new Vector2(power, 0f);

        //puts everything in motion
        t = 0f;
        isKicking = true;
    }
}
