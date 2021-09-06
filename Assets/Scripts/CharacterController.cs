using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Inventory Inventory;
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
        // Pak de beweging van de muis en sla het op in de MouseX variable
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
        // Als je linker muisknop drukt
        if (Input.GetMouseButton(0))
        {
            // Maak een ray van de camera tot de muis
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Schiet de laser de wereld in
            // Ray is de laser, hit is wat we raken, 100 is de afstand
            if (Physics.Raycast(ray, out hit, 100))
            {
                // Pak de afstand tussen onszelf en het blokje
                float distance = Vector3.Distance(hit.transform.position, gameObject.transform.position);
                if (distance < MaximumDistance)
                {
                    // Een component is een script wat op een object zit en we mogen alle variabelen veranderen
                    // Pak het Block component van het object dat we raken met de laser
                    // <> is om een class aan te geven
                    Block foundBlock = hit.transform.GetComponent<Block>();
                    if (foundBlock != null)
                    {
                        foundBlock.Damage(this);
                    }
                }
                
                Debug.DrawLine(ray.origin, hit.point, Color.red);
            }
        }
    }
}