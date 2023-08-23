using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    private float speed = 15f;
    private float xRange = 20f;
    private float zRange = 12f;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            LimitXRange(-xRange);
        }

        if (transform.position.x > xRange)
        {
            LimitXRange(xRange);
        }

        if (transform.position.z < -zRange)
        {
            LimitZRange(-zRange);
        }

        if (transform.position.z > zRange)
        {
            LimitZRange(zRange);
        }

        if (gameManager.isGameActive)
        {
            // Move player horizantally and vertically
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        }

    }

    // ABSTRACTION
    void LimitXRange(float xRange) 
    {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }

    void LimitZRange(float zRange)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Animal")
        {
            gameManager.GameOver();
        }

    }
}
