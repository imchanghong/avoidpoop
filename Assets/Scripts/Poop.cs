using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Poop : MonoBehaviour
{
    // 콜라이더 불러와 초기화
    private new PolygonCollider2D collider;
    private void Awake()
    {
        collider = GetComponent<PolygonCollider2D>();
    }
    // 똥맞으면 게임오버
    private void Update()
    {
        if (collider.IsTouching(GameManager.instance.player.collider))
        {
            Time.timeScale = 0;
            GameManager.instance.gameover = true;
        }
    }
    // y 좌표 이하로 내려가면 오브젝트 비활성화
    private void FixedUpdate()
    {
        if (transform.position.y < -5)
        {
            gameObject.SetActive(false);
        }
    }
}
