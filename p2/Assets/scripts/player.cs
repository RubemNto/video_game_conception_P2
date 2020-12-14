using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform target;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        target.SetParent(null);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position,target.position,movementSpeed*Time.deltaTime);
    }
}
