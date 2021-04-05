using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float RotationSpeed = 1;
    public float MovementSpeed = 1;
    public Rigidbody Rigidbody;
    public Transform CameraTransform;
    
    void Update()
    {
        var xMove = Input.GetAxis("Mouse X") * RotationSpeed;
        var yMove = Input.GetAxis("Mouse Y") * RotationSpeed;
        
        RotateCamera(yMove);
        HandleRotation(xMove);
        HandlePosition();
    }

    private void RotateCamera(float yMove)
    {
        CameraTransform.localEulerAngles = new Vector3(
            CameraTransform.localEulerAngles.x - yMove, 
            CameraTransform.localEulerAngles.y, 
            CameraTransform.localEulerAngles.z);
    }
    
    private void HandleRotation(float xMove)
    {
        transform.localEulerAngles = new Vector3(
            transform.localEulerAngles.x, 
            transform.localEulerAngles.y + xMove, 
            transform.localEulerAngles.z);
        
        /*var xMove = Input.GetAxis("Mouse X") * RotationSpeed;
        var yMove = Input.GetAxis("Mouse Y") * RotationSpeed;
        
        transform.localEulerAngles = new Vector3(
            transform.localEulerAngles.x - yMove, 
            transform.localEulerAngles.y + xMove, 
            transform.localEulerAngles.z);*/
    }

    private void HandlePosition()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Rigidbody.AddForce(transform.forward * MovementSpeed, ForceMode.Impulse);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody.AddForce(-transform.right * MovementSpeed, ForceMode.Impulse);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            Rigidbody.AddForce(-transform.forward * MovementSpeed, ForceMode.Impulse);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody.AddForce(transform.right * MovementSpeed, ForceMode.Impulse);
        }
    }
}
