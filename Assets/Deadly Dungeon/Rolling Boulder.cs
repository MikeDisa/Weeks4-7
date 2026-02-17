using UnityEngine;

public class RollingBoulder : MonoBehaviour
{
    public MovingBoulder movingBoulder;
    float speed = 50f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movingBoulder.rolling == true)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += speed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
    }

    
}

