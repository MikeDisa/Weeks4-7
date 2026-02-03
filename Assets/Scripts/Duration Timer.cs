using UnityEngine;
using UnityEngine.UI;

public class DurationTimer : MonoBehaviour
{
    public float duration = 0;
    public AudioSource audioSource;
    public Slider Duration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Duration.maxValue = audioSource.clip.length;
        
    }

    // Update is called once per frame
    void Update()
    {
        Duration.value = audioSource.time;
    }
}
