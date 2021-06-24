using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_spike_1_mm : MonoBehaviour
{
    RectTransform spike_rt;
    //private bool wayDown = false;

    private void Awake()
    {
        spike_rt = this.gameObject.GetComponent<RectTransform>();
    }

    void Start()
    {
        spike_rt.position = new Vector3(-2700, 175, 0);
    }

    void Update()
    {
        if(spike_rt.position.x < -850)
        {
            spike_rt.position = new Vector3(spike_rt.position.x + 1, -350, 0);
        }
        else if(spike_rt.position.x >= -850)
        {
            spike_rt.position = new Vector3(-850, spike_rt.position.y - 1, 0);
        }

        if (spike_rt.position.y <= -350)
            spike_rt.position = new Vector3(-2700, 175, 0);
    }
}
