using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public GameManager manager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().gameOver();
        }
    }


}
