using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int coins;
    //float y = 5;
    public string objectName;
    float position;
    float position1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        // Invoke("EagleChange",5);
       // StartCoroutine(EagleChange());
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider Col)
    {
        GameObject SomeGameObject = GameObject.Find(objectName);
        position = SomeGameObject.transform.position.y + 1;
        position1 = SomeGameObject.transform.position.y -1;
        if (Col.gameObject.tag == "coin")
        {
            //Debug.Log("Coin collected");
            coins = coins +1 ;
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
            //gameObject.transform.position = new Vector3(-11, y+1, 5);
            //SomeGameObject.GetComponent<Animation>().Play("up animation");
            //animator.SetTrigger("Lower Bridge");
            Debug.Log(SomeGameObject);
            SomeGameObject.transform.position = new Vector3(SomeGameObject.transform.position.x, position , SomeGameObject.transform.position.z);
        }
        else
        {
            //SomeGameObject.transform.position = new Vector3(-11, y - 1, 5);
            //yield return new WaitForSeconds(3);
            //SomeGameObject.transform.position = new Vector3(SomeGameObject.transform.position.x, position1, SomeGameObject.transform.position.z);
            // if (Time.deltaTime > 3)
            // {
            //     SomeGameObject.transform.position = new Vector3(SomeGameObject.transform.position.x, position1, SomeGameObject.transform.position.z);
            // }
            //Debug.Log("down");
            // SomeGameObject.transform.position = new Vector3Int(1,2,3);
        }
    }
    // public IEnumerator EagleChange()
    // {
    //     yield return new WaitForSeconds(5);
    //     Debug.Log("Talaku asuchi wa");
    //     //GameObject SomeGameObject = GameObject.Find(objectName);
    //    // SomeGameObject.transform.position = new Vector3(SomeGameObject.transform.position.x,SomeGameObject.transform.position.y-1, SomeGameObject.transform.position.z);
    //     yield return new WaitForSeconds(5);
    //     print("authare talaku asila");
    // }
 }
