using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character3DController : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 5.0F;

    [SerializeField]
    float rotationSpeed = 2.0F;

    [SerializeField]
    float jumpSpeed = 2.0F;

    [SerializeField]
    Joystick joystick;

    //CharacterController controller;

    void Start() { /*controller = GetComponent<CharacterController>();*/ }

    void Update() { MoveCharacterJoyStick(); RotateCharacter(); }

    void MoveCharacterJoyStick()
    {
        float horizontal = joystick != null ? joystick.Horizontal : Input.GetAxis("Horizontal");
        float vertical = joystick != null ? joystick.Vertical : Input.GetAxis("Vertical");
        Vector3 posicion =new Vector3(horizontal,0F,vertical);
        transform.Translate(posicion * movementSpeed * Time.deltaTime);
        /*if (Input.GetKeyDown("space") && !controller.isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 15000 * jumpSpeed * Time.deltaTime);
        }*/
    }

    void RotateCharacter()
    {
        float rotation = rotationSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(0, rotation, 0);
    }
}