using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public Playerscript movement;

   
    void OnCollisionEnter(Collision CollisionInfo)
    {
        if(CollisionInfo.collider.tag=="obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
