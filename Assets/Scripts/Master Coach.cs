using UnityEngine;
using UnityEngine.UI;

public class MasterCoach : MonoBehaviour
{
    public GameObject FootballPrefab;
    public GameObject targetCanvas;

    public Slider PowerSlider;

    public Button LaunchButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Football();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Football()
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

    public void ToggleCanvas()
    {
        targetCanvas.SetActive(!targetCanvas.activeSelf);
    }
}
