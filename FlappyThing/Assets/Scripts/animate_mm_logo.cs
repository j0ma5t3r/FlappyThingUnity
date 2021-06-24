using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animate_mm_logo : MonoBehaviour
{
    public Image logo1;
    public Image logo2;
    public Image logo3;

    private float tmr = 0f;

    private void Start()
    {
        logo2.enabled = false;
        logo3.enabled = false;
    }

    void Update()
    {
        tmr += Time.deltaTime;
        
        if(tmr < 0.33f)
        {
            logo1.enabled = true;
            logo2.enabled = false;
            logo3.enabled = false;
        }
        else if(tmr >= 0.33f && tmr < 0.66f)
        {
            logo1.enabled = false;
            logo2.enabled = true;
            logo3.enabled = false;
        }
        else if(tmr >= 0.66f)
        {
            logo1.enabled = false;
            logo2.enabled = false;
            logo3.enabled = true;
        }

        if (tmr >= 1f)
            tmr = 0f;
    }
}
