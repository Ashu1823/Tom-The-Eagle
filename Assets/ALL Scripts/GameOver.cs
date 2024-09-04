using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public void retry()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // SceneManager.LoadScene(2);
        Debug.Log("seta aka authare load heba");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
