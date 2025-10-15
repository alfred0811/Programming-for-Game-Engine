using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // We want to move the object left to right
    // - input system
    // - speed
    // - update in update loop
    // We want ro prevent the object from moving too far left/right
    // We want to catch falling objects
    // We want to get points if object is good, lose if bad

    // Mushroom if it misses player (hits ground)
    // bomb
    // UI/Points/Game Manager
    // - spawning drops

    [SerializeField]
    private float moveSpeed = 10.0f;
    [SerializeField]
    private float maxDistanceFromStart = 20.0f;
    private Vector3 startPosition = Vector3.zero;

    void Awake()
    {
        startPosition = transform.position;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            position.x += moveSpeed * Time.deltaTime;
        }

        // position.x = Mathf.Clamp(distanceFromStart) > maxDistanceFromStart
        float distanceFromStart = position.x - startPosition.x;
        if (Mathf.Abs(distanceFromStart) > maxDistanceFromStart)
        {
            if (distanceFromStart < 0)
            {
                position.x = startPosition.x - maxDistanceFromStart;
            }
            else
            {
                position.x = startPosition.x + maxDistanceFromStart;
            }
        }
        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null && collision.gameObject != null)
        {
            if(collision.gameObject.tag == "Mushroom")
            {
                Debug.Log("Mushroom get points");
                
            }
            else if(collision.gameObject.tag == "Bomb")
            {
                Debug.Log("Bomb lose points");
            }
            Destroy(collision.gameObject);
        }
    }
}
