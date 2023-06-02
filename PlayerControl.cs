using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float speed = moveSpeed;

        // Check if the shift key is held down
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            // Double the movement speed if shift key is held down
            speed *= 2f;
        }

        // Move the object horizontally based on input
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveHorizontal * speed * Time.deltaTime);

        // Move the object forward/backward based on input
        float moveVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * moveVertical * speed * Time.deltaTime);
    }
}

