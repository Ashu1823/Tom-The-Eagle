using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class UpperLowerLine : MonoBehaviour
{
    // Start is called before the first frame update
    // private void OnCollisionEnter(Collision other)
    // {
    //     if(other.gameObject.tag == "EagleDown"){
        
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    //     }
    // }
    // private void OnTriggerEnter(Collider other)
    // {
    //     //SceneManager.LoadScene(1);
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // }


    public GameObject canvas;
   // public string objectName;
    bool GamePaused;

    void Start()
    {
        GamePaused = false;
    }
    private void OnTriggerEnter(Collider other)
    {
       // GameObject SomeGameObject = GameObject.Find(objectName);
      // Selection.activeGameObject = gameObject;
        if (other.gameObject.tag == "EagleDown")
        {
            // SceneManager.LoadScene(1);
        canvas.SetActive(true);
        GamePaused = true;
        Debug.Log ("collied down");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
