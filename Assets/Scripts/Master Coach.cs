using UnityEngine;

public class MasterCoach : MonoBehaviour
{
    public GameObject FootballPrefab;
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

    }
}
