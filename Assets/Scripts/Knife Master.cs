using UnityEngine;

public class Knife : MonoBehaviour
{
    public MasterBarrel masterBarrel;
    public Piratepopup Piratepopup;
    public bool loser = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (masterBarrel.running = true && masterBarrel.knives[i].value == masterBarrel.triggerWord)
        //{

        //}
        if(loser == true)
        {
            Piratepopup.PiratePop();
        }
    }
}
