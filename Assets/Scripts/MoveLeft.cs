using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerControllerScript playerControllerScript;
    private float leftBound = -15;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerScript>();
    }

    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}