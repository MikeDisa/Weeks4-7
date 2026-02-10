using UnityEngine;

public class MasterBarrel : MonoBehaviour
{
    public int triggerWord = 0;
    public Knife[] knives = new Knife[5];
    public bool running = false;

    public GameObject knifePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        running = true;
        triggerWord = Random.Range(0,4);
        for (int i = 0; i < knives.Length; i++)
        {
            GameObject knifeSpawned = Instantiate(knifePrefab);
            Knife k = knifeSpawned.GetComponent<Knife>();
            k.masterBarrel = this;
            k.Piratepopup = knifeSpawned.GetComponent <Piratepopup>();
            knives[i] = k;
        }
        knives[triggerWord].loser = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
