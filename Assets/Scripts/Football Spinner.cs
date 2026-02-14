using UnityEngine;
using UnityEngine.WSA;

public class FootballSpinner : MonoBehaviour
{
    public FootballMover FootballMover;
   float speed = 300f;
    //public bool launch = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (FootballMover.isKicking)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += speed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
    }
}
