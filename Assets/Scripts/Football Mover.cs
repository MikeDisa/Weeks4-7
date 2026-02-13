using UnityEngine;
using UnityEngine.UI;

public class FootballMover: MonoBehaviour
{
    public Slider PowerSlider;


    public float maxDistance = 30f;
    public float maxHeight = 8f;
    public float duration = 1f;

     Vector2 startPos;
     Vector2 endPos;
     float time;
     bool isKicking = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    

    
    public void Kick()
    {
        startPos = transform.position;

        float power = PowerSlider.value; 

        float distance = power * maxDistance;

        
        //endPos = ;

        time = 0f;
        isKicking = true;
    }
}
