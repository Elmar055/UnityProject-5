using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    // Destroy ball prefabs when it collise dog
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
