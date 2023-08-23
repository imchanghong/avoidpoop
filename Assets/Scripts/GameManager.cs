using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameover;
    public static GameManager instance;
    public Player player;
    public PoolManager pool;
    public Timer timer;
    private void Awake()
    {
        Time.timeScale = 1.0f;
        instance = this;
    }
}