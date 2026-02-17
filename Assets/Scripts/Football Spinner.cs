using UnityEngine;
using UnityEngine.WSA;

//makes the football child sprite spin in place
public class FootballSpinner : MonoBehaviour
{
    public FootballMover FootballMover;
   float speed = 500f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //just a basic spin operation handled by the parent code
        if (FootballMover.isKicking)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += speed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
    }
}
