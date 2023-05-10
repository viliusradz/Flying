using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPMovement : MonoBehaviour
{
    public bool cursorLocked = true;
    public float sensitivity = 1.2f;

    public float speedMulti = 2f;
    private void Start()
    {
        if (cursorLocked)
            Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        MouseMovement();
        PositionMovement();
    }
    void PositionMovement()
    {
        if (Input.GetKey(KeyCode.W)) transform.position += transform.forward * speedMulti * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) transform.position += transform.forward * -speedMulti * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) transform.position += transform.right * -speedMulti * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) transform.position += transform.right * speedMulti * Time.deltaTime;

    }
    void MouseMovement()
    {
        var y = Input.GetAxis("Mouse X");
        var x = Input.GetAxis("Mouse Y");

        transform.Rotate(-x * sensitivity, y * sensitivity, 0);
    }
}
