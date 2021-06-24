using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fps : MonoBehaviour
{
    Text text;
    float fps_value;
    float tmr = 0f;
    
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        tmr += Time.deltaTime;

        if(tmr >= 0.5f)
        {
            tmr = 0f;
            fps_value = 1 / Time.deltaTime;
            text.text = Mathf.Round(fps_value).ToString();
        }
    }
}
