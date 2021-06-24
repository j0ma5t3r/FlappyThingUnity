using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lower_spike : MonoBehaviour
{
    public GameObject gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.GetComponent<GameManagement>().ReloadScene();
    }
}
