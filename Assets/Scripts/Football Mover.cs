using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class FootballMover: MonoBehaviour
{
    public Slider PowerSlider;

    public float power;

    public float t = 1;

    
     Vector2 startPos;
     Vector2 endPos;
     
     public bool isKicking = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        t = 0f;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isKicking) return;

        t += Time.deltaTime;

        if (t >= 1f)
        {
            t = 1f;
            isKicking = false;
        }

        Vector2 pos = Vector2.Lerp(startPos, endPos, t);

        float arc = 4 * 5 * t * (1 - t);
        pos.y += arc;

        transform.position = pos;
    }

    

    
    public void Kick()
    {
        startPos = transform.position;

        float power = PowerSlider.value;

        endPos = startPos + new Vector2(power, 0f);

        t = 0f;
        isKicking = true;


    }
}
