using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PoopSpawner : MonoBehaviour
{
    public Transform[] spawnPoint; 
    float timer;
    // √ ¥Á ¡® º”µµ
    private float speed = 0.4f;
    private void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > speed)
        {
            timer = 0f;
            Spawn();
        }
    }

    private GameObject Spawn()
    {
        GameObject poop = GameManager.instance.pool.Get(0);
        poop.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position;
        return poop;
    }
}