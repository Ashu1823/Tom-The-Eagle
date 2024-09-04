using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tom2 : MonoBehaviour
{
    public float moveSpeed = 3;
    private float jumpHeight = 2f;
    private float gravity = -50f;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
        if(Input.GetMouseButton(0))
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
        
    }
}
