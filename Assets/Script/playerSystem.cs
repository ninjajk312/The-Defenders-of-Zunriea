using UnityEngine;

public class playerSystem : MonoBehaviour
{
    public int powerLevel = 0;

    public float speed = 2.5f;
    public float xRange = 11.5f;
    public float yRange = 4.2f;

    public float horizontalInput;
    public float verticalInput;
    
    public GameObject[] projectiles;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftShift))
        {
            Instantiate(projectiles[powerLevel], transform.position, projectiles[powerLevel].transform.rotation);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.LeftArrow) ||
            Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed / 3);
            transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed / 3);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.LeftArrow) ||
            Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed / 3);
            transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed / 3);
        }
        else
        {
            transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);
            transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);
        }


    }
}
