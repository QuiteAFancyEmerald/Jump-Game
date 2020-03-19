using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Basic player script. Allows for movement right, left, and up.
/// </summary>
public class PlayerScript : MonoBehaviour
{
    public float movespeed; //controls speed of object.
    public Vector2 Jumpheight;

    /// <summary>
    /// Checks for which key is being pressed, and moves based on key.
    /// </summary>
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right");
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y); //allows the player to move right when the D key is pressed.
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left");
            GetComponent<Rigidbody2D>().velocity = new Vector2(- movespeed, GetComponent<Rigidbody2D>().velocity.y); // allows the player to move left with the A key is presed.
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Jump");
            GetComponent<Rigidbody2D>().AddForce(Jumpheight, ForceMode2D.Impulse);
            
        }
    }
}
