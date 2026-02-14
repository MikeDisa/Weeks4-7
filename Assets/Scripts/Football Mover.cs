using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class FootballMover: MonoBehaviour
{
    public Slider PowerSlider;

    public float t = 1;

    
     Vector2 startPos;
     Vector2 endPos;
     
     public bool isKicking = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.deltaTime;
       if (isKicking)
        {
            Kick();
        }
    }

    

    
    public void Kick()
    {
        startPos = transform.position;


        Vector2 pos = Vector2.Lerp(startPos, endPos, t);

        
        float arc = 4 * 5 * t * (1 - t);
        pos.y += arc;

        transform.position = pos;

       
        isKicking = true;
    }
}
