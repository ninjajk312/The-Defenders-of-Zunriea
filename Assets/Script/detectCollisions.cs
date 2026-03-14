using UnityEngine;

public class detectCollisions : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Other)
    {

        if(Other.gameObject.CompareTag("Boss"))
        {

            //code in bosses script!!!
            //Destroy(gameObject);
        }
        else if (Other.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Player Blast"))
            {

            }
            else
            {
                Destroy(gameObject);

                Destroy(Other.gameObject);
            }
        }
        else if (Other.gameObject.CompareTag("Enemy"))
        {
            if(gameObject.CompareTag("Enemy Blast"))
            {

            }
            else
            {
                Destroy(gameObject);

                Destroy(Other.gameObject);
            }
        }

    }
}
