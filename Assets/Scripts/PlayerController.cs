using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerScript : MonoBehaviour
{
    // for gravity and jumping      
    private Rigidbody playerRb;
    // for input system
    public InputAction jumpAction;

    public float jumpForce = 10;
    public float gravityModifier;
    void Start()
    {
        // get the rigidbody component and add an upward force to the player
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        // enable the jump action   
        jumpAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // check if the jump action is triggered
        if (jumpAction.triggered)
        {
            // add an upward force to the player
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}