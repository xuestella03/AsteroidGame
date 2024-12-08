using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;
    public float rotationSpeed = 150f;
    //public GameManager = GameManager;

    // Update is called once per frame
    void Update()
    {
        // forward/back/side
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(moveX, 0, moveZ);
        
        // rotation
        float rotateX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float rotateY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        Camera.main.transform.Rotate(0, rotateX, 0);
        Camera.main.transform.Rotate(-rotateY, 0, 0);

        // restriction to cube
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -50, 50), Mathf.Clamp(transform.position.y, -50, 50), Mathf.Clamp(transform.position.z, -50, 50));
    }
}
