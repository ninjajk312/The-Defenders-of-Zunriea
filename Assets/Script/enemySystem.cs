using UnityEngine;

public class enemySystem : MonoBehaviour
{
    public int blastCounter = 0;
    public int counter = 0;
    public int type = 1;
    public float speed = 1.5f;

    public GameObject projectile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

       


        if (blastCounter == 5)
        {
            speed = 5;

            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        else
        {

            if (counter == 250)
            {
                Instantiate(projectile, transform.position, projectile.transform.rotation);

                blastCounter++;
                counter = 0;
            }

            if (type == 1)
            {
                transform.Translate(Vector2.left * Time.deltaTime * speed);
            }
            else if (type == 2)
            {
                transform.Translate(Vector2.right * Time.deltaTime * speed);
            }
            else if(type == 3)
            {
                int i = 0;

                i = Random.Range(1, 5);

                transform.Translate(Vector2.down * Time.deltaTime * speed);

                switch (i)
                {
                    case 1:
                        transform.Translate(Vector2.right * Time.deltaTime * speed);
                        break;
                    case 2:
                        transform.Translate(Vector2.left * Time.deltaTime * speed);
                        break;
                    case 3:
                        transform.Translate(Vector2.down * Time.deltaTime * speed);
                        break;
                }

                
            }
            else if (type == 4)
            {
                transform.Translate(Vector2.down * Time.deltaTime * speed);
            }

        }

        counter++;
    }
}
