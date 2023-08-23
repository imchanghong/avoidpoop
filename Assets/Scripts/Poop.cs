using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Poop : MonoBehaviour
{
    // �ݶ��̴� �ҷ��� �ʱ�ȭ
    private new PolygonCollider2D collider;
    private void Awake()
    {
        collider = GetComponent<PolygonCollider2D>();
    }
    // �˸����� ���ӿ���
    private void Update()
    {
        if (collider.IsTouching(GameManager.instance.player.collider))
        {
            Time.timeScale = 0;
            GameManager.instance.gameover = true;
        }
    }
    // y ��ǥ ���Ϸ� �������� ������Ʈ ��Ȱ��ȭ
    private void FixedUpdate()
    {
        if (transform.position.y < -5)
        {
            gameObject.SetActive(false);
        }
    }
}
