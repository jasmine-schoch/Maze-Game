
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo){ //anything under will happen after object collides
        if(collisionInfo.collider.tag == "Finish")
        {
            //Debug.Log("We hit an obstacle.");
            movement.enabled = false;
        }
    }
}
