using UnityEngine;
using UnityEngine.UIElements;

public class bossOne : MonoBehaviour
{
    public int health = 10;
    public int blastCounter = 0;
    public int counter = 0;
    public float speed = 1.5f;
    public int type = 0;
    public bool move = false;

    public bool isDead = false;
    public GameObject[] projectile;
    public Vector3[] positions;

    // Update is called once per frame
    void Update()
    {
        if (type == 0)
        {
            BossOne();
        }
        else if (type == 1)
        {
            BossTwo();
        }
        else if (type == 2)
        {
            BossThree();
        }

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

            isDead = true;

            this.gameObject.SetActive(false);
        }


        if (counter == 1200)
        {
            teleport();
            counter = 0;
        }

        counter++;
    }

    void BossTwo()
    {

        if (counter == 500 || counter == 1000)
        {
            Blast();
        }


        if (health <= 0)
        {

            isDead = true;

            this.gameObject.SetActive(false);
        }

        if (health <= 10)
        {
            speed = 3;
        }

        if (health <= 5)
        {
            speed = 6;
        }

        if (counter == 1000)
        {
            counter = 0;
        }

        MoveLR();

        counter++;
    }

    void BossThree()
    {
        if (counter < 1000)
        {
            BlastR();
        }

        if (health <= 0)
        {

            isDead = true;

            this.gameObject.SetActive(false);
        }

        if (counter == 1000)
        {
            BlastL();
        }

        if (counter == 1500)
        {
            BlastL();
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
    void MoveLR()
    {
        if (transform.position.x <= -10)
        {
            move = true;
        }
        else if (transform.position.x >= 10)
        {
            move = false;
        }

        if (move == true)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        if (move == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
    }

    void BlastR()
    {
        Vector3 a = new Vector3(0, 3.5f, 0) + transform.position;

        Instantiate(projectile[1], a, projectile[1].transform.rotation);
    }

    void BlastL()
    {
        if (move == true) {
            Instantiate(projectile[0], transform.position, projectile[0].transform.rotation);

            move = false;
        }
        else
        {
            Instantiate(projectile[2], transform.position, projectile[2].transform.rotation);

            move = true;
        }
        
    }
}
