using UnityEngine;
using UnityEngine.UI;

public class MasterCoach : MonoBehaviour
{
    public GameObject FootballPrefab;
    public GameObject targetCanvas;

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
        if (reset && t<=delay)
        {
            t += Time.deltaTime;
        }
        if (!reset && t >= delay)
        {
            t = 0;
            Football();
        }
    }
    public void Football()
    {
        GameObject football = Instantiate(FootballPrefab);

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
