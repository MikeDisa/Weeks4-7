using UnityEngine;

public class MovingBoulder : MonoBehaviour
{
    public bool rolling = false;
    public SpriteRenderer player;

    float t = 0f;
    Vector2 startPos;
    Vector2 endPos;
    Vector2 playerHolder;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        t = 0f;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerHolder = player.transform.position;
        if (rolling)
        {
            t += Time.deltaTime;
            endPos = playerHolder;

            Vector2 pos = Vector2.Lerp(startPos, endPos, t);
            transform.position = pos;
        }
        else
        {
            return;
        }
    }
    public void TrapTrip()
    {
        rolling = true;
    }
}
