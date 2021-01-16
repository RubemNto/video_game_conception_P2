using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    public int RayCount = 1;
    public Transform raySpawnPosition;
    public LineRenderer laser;
    public Vector3 offset;
    void Start() 
    {
        laser = GetComponentInChildren<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        CastRay(raySpawnPosition.position,raySpawnPosition.transform.up,laser);
    }
    void CastRay(Vector3 position,Vector3 direction,LineRenderer _laser)
    {               
        _laser.positionCount = RayCount+1;        
        for (int i = 0; i < _laser.positionCount; i++)
        {
            Ray2D ray = new Ray2D(position,direction);
            RaycastHit2D hit;
            hit = Physics2D.Raycast(ray.origin,ray.direction,10);
            if(hit.collider != null && hit.transform.CompareTag("mirror"))
            {                
                //Debug.Log(hit.transform.name);
                Debug.DrawLine(position,hit.point,Color.red);
                _laser.SetPosition(i,position+offset);
                position = hit.point;
                direction = hit.normal;
                _laser.SetPosition(i+1,position+offset);                
            }else if(hit.collider != null && !hit.transform.CompareTag("mirror"))
            {
                Debug.DrawLine(position,hit.point,Color.blue);                
                _laser.SetPosition(_laser.positionCount-1,new Vector2(hit.point.x+offset.x,hit.point.y+offset.y));
                
            }      
        }
    }
}
