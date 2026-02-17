using UnityEngine;
using UnityEngine.UI;

public class MasterCoach : MonoBehaviour
{
    public GameObject FootballPrefab;
    public GameObject targetCanvas;

    public GoalZone goalZone;

    public Slider PowerSlider;

    public Button LaunchButton;

    float t = 0;
    float delay = 0.5f;
    bool reset = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        Football();
    }

    // Update is called once per frame
    void Update()
    {
        if (!reset) return;

        t += Time.deltaTime;

        if (t >= delay)
        {
            t = 0f;
            reset = false;
            Football();
        }
    }
    public void Football()
    {
        Debug.Log("SPAWN Football() called");

        GameObject football = Instantiate(FootballPrefab);

        if (goalZone != null) 
        { 
            goalZone.football = football.transform;
        }


        FootballMover mover = football.GetComponent<FootballMover>();

        football.GetComponent<FootballMover>();
        football.GetComponent<FootballSpinner>();
        mover.MasterCoach = this;

        mover.PowerSlider = PowerSlider;


        LaunchButton.onClick.RemoveAllListeners();
        LaunchButton.onClick.AddListener(mover.Kick);

    }

    public void Reset()
    {
        if (!reset)
        {
            reset = true;
        }
    }

 

    public void ToggleCanvas()
    {
        //apperently there's a one line toggle function for game object active states
        //it's the true/false equivalent of multiplying by -1 
        targetCanvas.SetActive(!targetCanvas.activeSelf);
    }
}
