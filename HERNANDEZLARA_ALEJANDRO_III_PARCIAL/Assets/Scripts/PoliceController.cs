using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceController : MonoBehaviour
{
    [SerializeField]
    float radius;
    [SerializeField]
    Transform viewPoint;
    [SerializeField]
    Transform player;
    [SerializeField]
    float killingTime = 5.0F;
    float startedTime;
    float elapsedTime;
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(viewPoint.position, radius);
    }
    void Update()
    {
        float distance = Mathf.Abs(Vector3.Distance(transform.position, player.position));
        if (distance != 0 && distance > 0.01 && distance < radius)
        {
            if (startedTime == 0)
            {
                startedTime = Time.time;
            }
            elapsedTime = Time.time - startedTime;
            if (elapsedTime >= killingTime)
            {
                PlayerController controller = FindObjectOfType<PlayerController>();
                controller.Lose();
            }
        }
        else
        {
            startedTime = 0.0F;
            elapsedTime = 0.0F;
        }
    }
}