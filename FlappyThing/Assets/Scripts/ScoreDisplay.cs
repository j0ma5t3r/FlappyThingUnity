using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    GameObject gm;
    public Text text;

    void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    void Update()
    {
        text.text = gm.GetComponent<GameManagement>().score.ToString();
    }
}
