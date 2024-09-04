using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject canvas;
    bool GamePaused;
    void Start()
    {
        GamePaused = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        // SceneManager.LoadScene(1);
        canvas.SetActive(true);
        GamePaused = true;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
