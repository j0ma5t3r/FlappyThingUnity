using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_increase : MonoBehaviour
{
    GameObject gm;

    void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.GetComponent<GameManagement>().score += 1;
    }
}
