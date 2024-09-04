using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public float movementSpeed = 5;
    bool MoveRight = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EagleUp", 5.0f, 7.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveRight)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5.0f);
        }
        
    }
    void EagleUp()
    {
        Debug.Log(" Going Down Baby");
        transform.position = new Vector3(transform.position.x,transform.position.y-1, transform.position.z);
    }
    private void OnCollisionEnter(Collision colition)
    {
        if (colition.gameObject.tag == "EagleDown")
        {
            Debug.Log("eagle marigala nua gote khoja");
            //Destroy(gameObject);
        }
    }
        
    
}
