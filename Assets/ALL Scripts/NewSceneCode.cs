using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneCode : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("New scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
