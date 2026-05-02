using UnityEngine;

public class FaloEnemy : MonoBehaviour
{
    public int blastCounter = 0;
    public int counter = 0;
    public int type = 1;
    public float speed = 0.5f;
    public bool move = false;// False - Left || True - Right

    public GameObject projectile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 100)
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);

            blastCounter++;
            counter = 0;
        }

        if (transform.position.x <= -10)
        {
            move = true;
        }
        else if(transform.position.x >= 10)
        {
            move = false;
        }

        if (move == true)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        if(move == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

        counter++;
    }
}
