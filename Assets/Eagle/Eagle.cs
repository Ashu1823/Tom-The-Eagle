using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    //[SerializeField] LayerMask groundLayers;
    [SerializeField] private float runspeed ;

    //private float gravity = -50f;
    private CharacterController characterController;
    private Vector3 velocity;
   // private bool isGrounded;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = 1;

        //face forword
        transform.forward = new Vector3(verticalInput, 0, Mathf.Abs(verticalInput) - 1);

        //isgrounded
        //isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundLayers, QueryTriggerInteraction.Ignore);

        /*if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0;
        }*/

        characterController.Move(new Vector3(verticalInput * runspeed, 0, 0) * Time.deltaTime);

       /* if (isGrounded && Input.GetMouseButton(0))
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
       */
        //vertical velocity
        characterController.Move(velocity * Time.deltaTime);
    }
}
