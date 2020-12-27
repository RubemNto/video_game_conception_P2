using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects : MonoBehaviour
{
    public bool rotate = false;
    public float rotateSpeed = 90;

    void Update()
    {
        if(rotate)
        {
            transform.Rotate(0,0,rotateSpeed*-Time.deltaTime);
        }
    }
}
