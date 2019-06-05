using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rgbd = null;
    private float MovementSpeed = 100f;

    void FixedUpdate()
    {    
      
        if (Input.GetKey(KeyCode.A))
        {
            rgbd.AddForce(Vector2.left*MovementSpeed, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rgbd.AddForce(Vector2.right * MovementSpeed, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rgbd.AddForce(Vector2.up * 2, ForceMode2D.Impulse);
        }
        // Stops the Cube 
        if (Input.GetKey(KeyCode.S))
        {
            rgbd.AddForce(Vector2.down * 1000, ForceMode2D.Force);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            // TODO: impelemt flash light activity and moving disability here
            rgbd.AddForce(Vector2.down * 2000, ForceMode2D.Force);
        }
    }
}
