using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public Text ScriptTxt;
    public float timer;
    public int Score;

    private void Awake()
    {
        ScriptTxt = GetComponent<Text>();
        ScriptTxt.text = "���� : ";
    }

    private void Update()
    {
        timer += Time.deltaTime;
        Score = (int)(Math.Round(timer, 1) * 10);
        ScriptTxt.text = "���� : " + Score.ToString();
    }
}
