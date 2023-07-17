using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rigidBody;

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        PlayerMovement();

    }

    void PlayerInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddForce(Vector2.up * 50);
        }
    }

    void PlayerMovement()
    {
        rigidBody.AddForce(Vector2.right * 20 * Time.deltaTime);
    }
}