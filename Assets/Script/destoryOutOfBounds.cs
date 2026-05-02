using UnityEngine;

public class destoryOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float lowerBound = -10;
    public float sideBound = 16;

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > sideBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
    }
}
