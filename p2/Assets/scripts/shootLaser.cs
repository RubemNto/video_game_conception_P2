using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootLaser : MonoBehaviour
{
    public Material material;
    laserBeam beam;

    // Update is called once per frame
    void Update()
    {
        Destroy(GameObject.Find("Laser Beam"));
        beam = new laserBeam(gameObject.transform.position,gameObject.transform.right,material);
    }
}
