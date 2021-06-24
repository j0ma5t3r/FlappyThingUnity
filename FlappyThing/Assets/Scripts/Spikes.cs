using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x - (speed * Time.deltaTime), transform.position.y, transform.position.z);

        if (transform.position.x <= -15f)
            Destroy(gameObject);
    }
}
