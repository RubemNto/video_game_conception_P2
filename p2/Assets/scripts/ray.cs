using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    public int RayCount = 1;
    public Transform raySpawnPosition;
    public LineRenderer laser;
    void Start() 
    {
        laser = GetComponentInChildren<LineRenderer>();
        laser.positionCount = RayCount+1;
        laser.SetPosition(0,raySpawnPosition.position);
    }

    // Update is called once per frame
    void Update()
    {
        CastRay(raySpawnPosition.position,transform.up,laser);
    }

    void CastRay(Vector3 position,Vector3 direction,LineRenderer _laser)
    {
        for (int i = 0; i < RayCount; i++)
        {
            Ray2D ray = new Ray2D(position,direction);
            RaycastHit2D hit;
            Vector3 hitPos;

            hit = Physics2D.Raycast(ray.origin,ray.direction,10);
            //hitPos = hit.transform.position-position;
            hitPos = new Vector3(hit.point.x - position.x,hit.point.y-position.y,0);
            if(hit.collider != null && hit.transform.tag == "mirror")
            {                
                // Debug.Log(hitPos);
                Debug.DrawLine(position,hit.point,Color.red);
                _laser.SetPosition(i+1,hitPos);
                position = hit.point;
                direction = hit.normal;

            }else
            {                
                //Debug.Log("Nothing Hit");
                //_laser.SetPosition(_laser.positionCount-1,_laser.GetPosition(_laser.positionCount-2)*100f);
                Debug.DrawRay(position,direction*10,Color.blue);
                break;
            }


            // if(Physics2D.Raycast(ray,out hit,10,1))
            // {
            //     Debug.DrawLine(position,hit.point,Color.red);
            //     position = hit.point;
            //     direction = hit.normal;

            // }else
            // {
            //     Debug.DrawRay(position,direction*10,Color.blue);
            //     break;
            // }         
        }
    }
}
