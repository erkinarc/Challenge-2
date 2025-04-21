using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeSinceLastDog = 0f;
    private float dogSpawnDelay = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceLastDog < Time.time)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            timeSinceLastDog = Time.time + dogSpawnDelay; // Set the time for the next dog spawn
        }
    }
}
