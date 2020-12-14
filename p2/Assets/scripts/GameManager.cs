using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform targetPlayer;
    public LayerMask world;
    //targetPlayer Movement Functions
    public void Move_UP()
    {
        if(Physics2D.OverlapCircle(targetPlayer.position+new Vector3(0,1,0),0.1f,world))
        {
            targetPlayer.position = targetPlayer.position+new Vector3(0,1,0);
        }
    }
    public void Move_DOWN()
    {
        if(Physics2D.OverlapCircle(targetPlayer.position+new Vector3(0,-1,0),0.1f,world))
        {
            targetPlayer.position = targetPlayer.position+new Vector3(0,-1,0);
        }
    }
    public void Move_LEFT()
    {
        if(Physics2D.OverlapCircle(targetPlayer.position+new Vector3(-1,0,0),0.1f,world))
        {
            targetPlayer.position = targetPlayer.position+new Vector3(-1,0,0); 
        }
    }
    public void Move_RIGHT()
    {
        if(Physics2D.OverlapCircle(targetPlayer.position+new Vector3(1,0,0),0.1f,world))
        {
            targetPlayer.position = targetPlayer.position+new Vector3(1,0,0);
        }
    }
    public void ROTATE()
    {

    }
    public void GRAB()
    {

    }
}
