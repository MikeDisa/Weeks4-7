using UnityEngine;
using UnityEngine.UI;

public class MasterCoach : MonoBehaviour
{
    //this was my main manager script that spawnw=ed and hooked up all the components
    public GameObject FootballPrefab;
    public GameObject targetCanvas;

    public GoalZone goalZone;

    public Slider PowerSlider;

    public Button LaunchButton;

    //setup components for the spawn timer
    float t = 0;
    float delay = 0.5f;
    bool reset = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //spawns the starting football 
        Football();
    }

    // Update is called once per frame
    void Update()
    {
        //another line of null protection
        if (!reset) return;

        t += Time.deltaTime;
        //internal timer that puts a brief pause between football spawns
        if (t >= delay)
        {
            t = 0f;
            reset = false;
            Football();
        }
    }

    //a football spawning function that I can call instead of . . . I guess that's not as clever as I thought it was
    public void Football()
    {
        Debug.Log("SPAWN Football() called");

        GameObject football = Instantiate(FootballPrefab);

        //again, null errors was just a big problem with this one. I didn't know that it would just stop running code if it null errored
        if (goalZone != null) 
        { 
            goalZone.football = football.transform;
        }

        //hooks up football parent object to it's script
        FootballMover mover = football.GetComponent<FootballMover>();

        //hooks up football parent and child to their managing scripts
        football.GetComponent<FootballMover>();
        football.GetComponent<FootballSpinner>();
        //hooks up this script
        mover.MasterCoach = this;
        //hooks up the UI slider
        mover.PowerSlider = PowerSlider;

        //removes and then hooks up the UI button. because not removing it right makes it null error
        LaunchButton.onClick.RemoveAllListeners();
        LaunchButton.onClick.AddListener(mover.Kick);

    }

    //starts the tinternal timer, called by the football
    public void Reset()
    {
        if (!reset)
        {
            reset = true;
        }
    }

 
    //called by the help button
    public void ToggleCanvas()
    {
        //apperently there's a one line toggle function for game object active states
        //it's the true/false equivalent of multiplying by -1 
        targetCanvas.SetActive(!targetCanvas.activeSelf);
    }
}
