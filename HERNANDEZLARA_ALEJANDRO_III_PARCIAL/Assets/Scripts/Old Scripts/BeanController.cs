using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5F;

    [SerializeField]
    float jumpSpeed = 5F;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        Vector3 position = new Vector3(Input.GetAxis("Horizontal"), 0F, Input.GetAxis("Vertical"));
        transform.Translate(position * moveSpeed * Time.deltaTime);
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 15000 * jumpSpeed * Time.deltaTime);
        }
    }
}