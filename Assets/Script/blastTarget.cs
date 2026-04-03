using UnityEngine;

public class blastTarget : MonoBehaviour
{

    public float speed = 5;
    public int CountMax = 2000;
    public int Count = 0;

    private Transform playerPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPos = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (playerPos == null)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(playerPos.position * Time.deltaTime * speed);
        }

        if (Count > CountMax) 
        {
            Destroy(gameObject);
        }

        Count++;
    }
}
