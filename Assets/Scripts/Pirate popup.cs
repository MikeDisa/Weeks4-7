using UnityEngine;

public class Piratepopup : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector2 (0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PiratePop()
    {
        Vector2 newPosition = new Vector2(0, 4);
        transform.position = newPosition;
    }
}
