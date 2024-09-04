using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "coin")
        {
            Debug.Log("eagle uparaku gala wa dekha");
            gameObject.GetComponent<Animator>().Play("down animation");
        }
    }

}
