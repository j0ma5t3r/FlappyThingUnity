using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slow_rotate : MonoBehaviour
{
    public Image bgimg;
    RectTransform bgimg_rt;
    public float speed = 1f;

    private void Start()
    {
        bgimg_rt = bgimg.GetComponent<RectTransform>();
    }

    void Update()
    {
        bgimg_rt.Rotate(new Vector3(0, 0, speed * Time.deltaTime * -1));
    }
}
