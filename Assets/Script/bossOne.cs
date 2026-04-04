using UnityEngine;
using UnityEngine.UIElements;

public class bossOne : MonoBehaviour
{
    public int health = 10;
    public int blastCounter = 0;
    public int counter = 0;
    public float speed = 1.5f;

    public GameObject[] projectile;
    public Vector3[] positions;

    // Update is called once per frame
    void Update()
    {
        BossOne();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Player Blast"))
        {
            health--;
        }
    }
    void BossOne()
    {
        if (counter == 250 || counter == 750 || counter == 1200)
        {
            Blast();
        }


        if (health <= 0)
        {
            Destroy(gameObject);
        }


        if (counter == 1200) 
        {
            teleport();
            counter = 0;
        }

        counter++;
    }
    void Blast()
    {
        int random_number = Random.Range(0, 3);

        if (random_number == 0)
        {
            Instantiate(projectile[1], transform.position, projectile[1].transform.rotation);
            Instantiate(projectile[1], transform.position, projectile[1].transform.rotation);
        }
        else if (random_number == 1)
        {
            Instantiate(projectile[0], transform.position, projectile[0].transform.rotation);
        }
        else if (random_number == 2)
        {
            Instantiate(projectile[0], transform.position, projectile[0].transform.rotation);
            Instantiate(projectile[0], transform.position, projectile[0].transform.rotation);
        }
        else if (random_number == 3)
        {
            Instantiate(projectile[1], transform.position, projectile[1].transform.rotation);
        }
    }
    void teleport()
    {
        int random_number = Random.Range(0, 3);

        if (random_number == 0)
        {
            transform.position = positions[0];
        }
        else if (random_number == 1) 
        {
            transform.position = positions[1];
        }
        else if (random_number == 2)
        {
            transform.position = positions[2];
        }
        else if (random_number == 3)
        {
            transform.position = positions[3];
        }
    }

}
