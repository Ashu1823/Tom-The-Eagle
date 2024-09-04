using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    bool GamePaused;
    void Start()
    {
        GamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "Obstacle");
        {
            canvas.SetActive(true);
            GamePaused = true;
            Debug.Log("obstacle");
        }  
    }
   
}
