using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void playgame()
    {
        SceneManager.LoadScene(1);

    }
    public void Quitmenu()
    {
        //Debug.Log("Quit...");
        Application.Quit();
    }
}
