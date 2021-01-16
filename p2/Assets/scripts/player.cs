using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Transform target;
    public float movementSpeed;
    //public bool grab = false;
    public GameObject contactObject;
    public GameObject collectedObject;
    // Start is called before the first frame update
    void Start()
    {
        target.SetParent(null);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position,target.position,movementSpeed*Time.fixedDeltaTime);
    }

    // void OnTriggerEnter2D(Collider2D other) 
    // {
    //     if(other.gameObject.tag=="object")
    //     {
    //         contactObject = other.gameObject;
    //     }

    //     if(other.gameObject.tag == "exit")
    //     {
    //         SceneManager.LoadScene(0);
    //     }        
    // }
    // void OnTriggerExit2D(Collider2D other) 
    // {
    //     if(other.gameObject.tag=="object")
    //     {
    //         contactObject.GetComponent<objects>().rotate = false;
    //         contactObject = null;
    //     }        
    // }
}
