using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10f; //Movement Speed
    public float rotSpeed = 20f; //Rotation Speed

    void Update() {
        float horizontalInput = Input.GetAxis("Horizontal"); // Left or Right
        float verticalInput = Input.GetAxis("Vertical"); //Up or Down

        Vector3 directionInput = new Vector3(horizontalInput, 0, verticalInput); //Storing movement variables (Up, down, left, right)
        Vector3 rotDirection = new Vector3(0f, horizontalInput, 0f); //Storing rotation variables (left, right)
        
        transform.Translate(directionInput * Time.deltaTime * speed); //Applying movement
        transform.Rotate(rotDirection * Time.deltaTime * rotSpeed); //Applying Rotation
    }
}
