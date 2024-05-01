using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool cooldown = false;
    public float lastPressTime = 0f;
    public float cooldownDuration = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !cooldown)
        {
            cooldown = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastPressTime = Time.time;
        }

        if (cooldown && Time.time - lastPressTime >= cooldownDuration)
        {
            cooldown = false;
        }
    }
}
