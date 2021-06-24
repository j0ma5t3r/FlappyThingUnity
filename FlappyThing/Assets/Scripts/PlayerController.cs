using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject gm;

    private Rigidbody2D rb;
    void Awake()
    {
        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - (8f * Time.deltaTime));

        if (transform.position.y >= 4.3f || transform.position.y <= -4.3f)
            gm.GetComponent<GameManagement>().ReloadScene();
    }

    public void Jump()
    {
        rb.velocity = new Vector2(0.0f, 5.0f);
    }
}
