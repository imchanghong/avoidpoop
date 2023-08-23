using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI txt;
    private int score;

    private void Awake()
    {
        panel = GameObject.Find("EndPanel");
        txt = panel.GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        if (GameManager.instance.gameover)
        {
            panel.SetActive(true);
            score = GameManager.instance.timer.Score;
            //txt.text = "Á¡¼ö : " + score.ToString();
        }
    }
}
