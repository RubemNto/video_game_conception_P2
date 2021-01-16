using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform targetPlayer;
    public LayerMask world;
    public GameObject player;
    public float turnSmoothVelocity;
    public float turnSmoothTime;
    //public player playerData;
    bool moveUp,moveDown,moveLeft,moveRight;
    //targetPlayer Movement Functions
    public void Move_UP()
    {
        Ray ray = new Ray(targetPlayer.position+new Vector3(0,0,1f),Vector3.down);
        RaycastHit hit;
        Debug.DrawRay(ray.origin,ray.direction*100f,Color.red,5f);
        if(Physics.Raycast(ray.origin,ray.direction,out hit,100f))
        {
            if(hit.transform.tag == "ground")
            {
                targetPlayer.position += new Vector3(0,0,0.5f);
                // float targetAngle = Mathf.Atan2(targetPlayer.position.x,targetPlayer.position.z)*Mathf.Rad2Deg;
                // float angle = Mathf.SmoothDampAngle(player.transform.eulerAngles.y,targetAngle,ref turnSmoothVelocity,turnSmoothTime);
                player.transform.rotation = Quaternion.Euler(0f,0f,0f);
            }
        }
    }
    public void Move_DOWN()
    {
        Ray ray = new Ray(targetPlayer.position-new Vector3(0,0,1f),Vector3.down);
        RaycastHit hit;
        Debug.DrawRay(ray.origin,ray.direction*100f,Color.red,5f);
        if(Physics.Raycast(ray.origin,ray.direction,out hit,100f))
        {
            if(hit.transform.tag == "ground")
            {
                targetPlayer.position -= new Vector3(0,0,0.5f);
                // float targetAngle = Mathf.Atan2(targetPlayer.position.x,targetPlayer.position.z)*Mathf.Rad2Deg;
                // float angle = Mathf.SmoothDampAngle(player.transform.eulerAngles.y,targetAngle,ref turnSmoothVelocity,turnSmoothTime);
                player.transform.rotation = Quaternion.Euler(0f,180f,0f);
            }
        }
    }
    public void Move_LEFT()
    {
        Ray ray = new Ray(targetPlayer.position-new Vector3(1f,0,0),Vector3.down);
        RaycastHit hit;
        Debug.DrawRay(ray.origin,ray.direction*100f,Color.red,5f);
        if(Physics.Raycast(ray.origin,ray.direction,out hit,100f))
        {
            if(hit.transform.tag == "ground")
            {
                targetPlayer.position -= new Vector3(0.5f,0,0);
                // float targetAngle = Mathf.Atan2(targetPlayer.position.x,targetPlayer.position.z)*Mathf.Rad2Deg;
                // float angle = Mathf.SmoothDampAngle(player.transform.eulerAngles.y,targetAngle,ref turnSmoothVelocity,turnSmoothTime);
                player.transform.rotation = Quaternion.Euler(0f,-90f,0f);
            }
        }
    }
    public void Move_RIGHT()
    {
        Ray ray = new Ray(targetPlayer.position+new Vector3(1f,0,0),Vector3.down);
        RaycastHit hit;
        Debug.DrawRay(ray.origin,ray.direction*100f,Color.red,5f);
        if(Physics.Raycast(ray.origin,ray.direction,out hit,100f))
        {
            if(hit.transform.tag == "ground")
            {
                targetPlayer.position += new Vector3(0.5f,0,0);
                // float targetAngle = Mathf.Atan2(targetPlayer.position.x,targetPlayer.position.z)*Mathf.Rad2Deg;
                // float angle = Mathf.SmoothDampAngle(player.transform.eulerAngles.y,targetAngle,ref turnSmoothVelocity,turnSmoothTime);
                player.transform.rotation = Quaternion.Euler(0f,90f,0f);
            }
        }
    }
    public void ROTATE()
    {
        // if(playerData.contactObject != null)
        // {
        //     playerData.contactObject.GetComponent<objects>().rotate = !playerData.contactObject.GetComponent<objects>().rotate;
        // }
    }
    public void GRAB()
    {
        // if(playerData.contactObject !=null && playerData.collectedObject == null)//found object with nothing in hand
        // {
        //     //collect object
        //     //Debug.Log("Here 1");
        //     playerData.collectedObject = playerData.contactObject;
        //     playerData.collectedObject.transform.SetParent(GameObject.Find("player").transform);
        //     playerData.collectedObject.SetActive(false);
        // }else if(playerData.contactObject == null && playerData.collectedObject != null)//found nothing but have something in hand
        // {
        //     //drop object
        //     //Debug.Log("Here 2");
        //     playerData.collectedObject.transform.SetParent(null);
        //     playerData.collectedObject.SetActive(true);
        //     playerData.collectedObject = null;
        // }else if(playerData.contactObject != null && playerData.collectedObject != null)//found something and have something in hand
        // {
        //     //switch object
        //     GameObject momentObject = playerData.collectedObject;
        //     playerData.collectedObject = playerData.contactObject;
        //     playerData.collectedObject.transform.SetParent(GameObject.Find("player").transform);
        //     playerData.collectedObject.SetActive(false);
        //     momentObject.transform.SetParent(null);
        //     momentObject.SetActive(true);            
        // }
    }
}
