using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoahCharacterController : MonoBehaviour
{
    public float MouseX;
    public float MouseY;
    
    public float JumpSpeed;
    public float Speed = 0.5f;
    public Rigidbody PlayerRigidbody;
    public Collider PlayerCollider;
    public float DistanceToGround;
    public Transform CameraTransform;

    public float MaximumDistance = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        DistanceToGround = PlayerCollider.bounds.extents.y;
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -transform.up, DistanceToGround + 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        Bewegen();
        Hakken();
    }

    void Bewegen()
    {
        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y");

        transform.localEulerAngles = new Vector3(
            transform.localEulerAngles.x, 
            transform.localEulerAngles.y + MouseX, 
            transform.localEulerAngles.z);
        
        CameraTransform.localEulerAngles = new Vector3(
            CameraTransform.localEulerAngles.x - MouseY, 
            CameraTransform.localEulerAngles.y, 
            CameraTransform.localEulerAngles.z);
        
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            PlayerRigidbody.AddForce(transform.up * JumpSpeed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerRigidbody.AddForce(transform.right * Speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerRigidbody.AddForce(-transform.right * Speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayerRigidbody.AddForce(-transform.forward * Speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.W))
        {
            PlayerRigidbody.AddForce(transform.forward * Speed, ForceMode.Impulse);
        }
    }

    void Hakken()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                float distance = Vector3.Distance(hit.transform.position, gameObject.transform.position);
                if (distance < MaximumDistance)
                {
                    Block foundBlock = GetComponent<Block>();
                    if (foundBlock != null)
                    {
                        
                    }
                }
                
                Debug.DrawLine(ray.origin, hit.point, Color.red);
            }
        }
    }
}