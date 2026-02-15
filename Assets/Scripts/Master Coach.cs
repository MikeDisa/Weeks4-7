using UnityEngine;
using UnityEngine.UI;

public class MasterCoach : MonoBehaviour
{
    public GameObject FootballPrefab;

    public Slider PowerSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(FootballPrefab);
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

        mover.PowerSlider = PowerSlider;


    }
}
