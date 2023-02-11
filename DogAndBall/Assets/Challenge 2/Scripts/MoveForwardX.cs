using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    // speed of prefab
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // prefab movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
