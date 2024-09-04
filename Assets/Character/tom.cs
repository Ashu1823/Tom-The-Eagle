using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tom : MonoBehaviour
{
    [SerializeField] LayerMask groundLayers;
    [SerializeField] private float runspeed = 8f;
    [SerializeField] private float jumpHeight = 2f;

    private float gravity = -50f;
    private CharacterController characterController;
    private Vector3 velocity;
    private bool isGrounded;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    
    void Update()
    {
        horizontalInput = 1;

        //face forword
        transform.forward = new Vector3(horizontalInput, 0, Mathf.Abs(horizontalInput) - 1);

        //isgrounded
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundLayers, QueryTriggerInteraction.Ignore);

        if(isGrounded  && velocity.y < 0)
        {
            velocity.y = 0;
        }
        else
        {
            //gravity
            velocity.y += gravity * Time.deltaTime;

        }

        characterController.Move(new Vector3(horizontalInput * runspeed, 0, 0) * Time.deltaTime);

       if(isGrounded && Input.GetMouseButton(0))
       {
            velocity.y += Mathf.Sqrt(jumpHeight * -2 * gravity);
       }

        //vertical velocity
        characterController.Move(velocity * Time.deltaTime);

        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "path")
        {
            Destroy(gameObject);
            //SceneManager.LoadScene(0);
            //Debug.Log("destroy..");
        }
    }

}
