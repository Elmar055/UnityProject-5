using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // gameobject variables for create a clone of dog prefab
    public GameObject dogPrefab;
    // variable to prevent the dog from running endlessly
    private float coolDown = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && coolDown <= 0)
        {
            // clone and send dogprefab
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            coolDown = 1;
        }
        if (coolDown >= 0)
        {
            // refresh cooldown
            coolDown -= Time.deltaTime;
        }
        //Debug.Log(Time.deltaTime);
        //Debug.Log(coolDown);
    }
}
