using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public TextBehaviour textScript;
    public bool playerDeath = false;

    private void Start()
    {
        rigidBody.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        if (textScript.gameStarted)
        {
            rigidBody.bodyType = RigidbodyType2D.Dynamic;
            PlayerInput();
            PlayerMovement();
        }

    }

    void PlayerInput()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            rigidBody.AddForce(Vector2.up * 50);
        }
    }

    void PlayerMovement()
    {
        rigidBody.AddForce(Vector2.right * 20 * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            playerDeath = true;
            Destroy(rigidBody);
        }
    }
}
