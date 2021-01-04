using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform targetPlayer;
    public LayerMask world;
    public Vector2[] positions;
    public player playerData;
    bool moveUp,moveDown,moveLeft,moveRight;
    //targetPlayer Movement Functions
    public void Move_UP()
    {
        if(!Physics2D.OverlapCircle(targetPlayer.position+new Vector3(0,1,0),0.1f,world))
        {
            targetPlayer.position = targetPlayer.position+new Vector3(0,1,0);
        }
    }
    public void Move_DOWN()
    {
        if(!Physics2D.OverlapCircle(targetPlayer.position+new Vector3(0,-1,0),0.1f,world))
        {
            targetPlayer.position = targetPlayer.position+new Vector3(0,-1,0);
        }
    }
    public void Move_LEFT()
    {
        if(!Physics2D.OverlapCircle(targetPlayer.position+new Vector3(-1,0,0),0.1f,world))
        {
            targetPlayer.position = targetPlayer.position+new Vector3(-1,0,0); 
        }
    }
    public void Move_RIGHT()
    {
        if(!Physics2D.OverlapCircle(targetPlayer.position+new Vector3(1,0,0),0.1f,world))
        {
            targetPlayer.position = targetPlayer.position+new Vector3(1,0,0);
        }
    }
    public void ROTATE()
    {
        if(playerData.contactObject != null)
        {
            playerData.contactObject.GetComponent<objects>().rotate = !playerData.contactObject.GetComponent<objects>().rotate;
        }
    }
    public void GRAB()
    {
        if(playerData.contactObject !=null && playerData.collectedObject == null)//found object with nothing in hand
        {
            //collect object
            //Debug.Log("Here 1");
            playerData.collectedObject = playerData.contactObject;
            playerData.collectedObject.transform.SetParent(GameObject.Find("player").transform);
            playerData.collectedObject.SetActive(false);
        }else if(playerData.contactObject == null && playerData.collectedObject != null)//found nothing but have something in hand
        {
            //drop object
            //Debug.Log("Here 2");
            playerData.collectedObject.transform.SetParent(null);
            playerData.collectedObject.SetActive(true);
            playerData.collectedObject = null;
        }else if(playerData.contactObject != null && playerData.collectedObject != null)//found something and have something in hand
        {
            //switch object
            GameObject momentObject = playerData.collectedObject;
            playerData.collectedObject = playerData.contactObject;
            playerData.collectedObject.transform.SetParent(GameObject.Find("player").transform);
            playerData.collectedObject.SetActive(false);
            momentObject.transform.SetParent(null);
            momentObject.SetActive(true);            
        }
    }
}
