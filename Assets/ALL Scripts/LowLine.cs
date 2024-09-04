using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LowLine : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            canvas.SetActive(true);
        }
    }
}
