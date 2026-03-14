using UnityEngine;

public class blastUp : MonoBehaviour
{
    public float speed = 20;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}
