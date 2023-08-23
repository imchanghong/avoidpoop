using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    public new PolygonCollider2D collider;
    private float horizontalInput;
    private float maxWidth;
    private Rigidbody2D rb;
    private Touch touch;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = rb.GetComponent<PolygonCollider2D>();
        maxWidth = Screen.width;
    }
    // Ű���� �Է� �ޱ�
    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        // ��������
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void FixedUpdate()
    {
        // Ű���� �̵�
        keyMove();

        // ����� ��ġ �̵�
        touchMove();

    }

    // �¿� �̵��� �¿� ����
    private void LateUpdate()
    {
        // �Ͻ������϶� ��� ����
        if (GameManager.instance.gameover) return;
        if (horizontalInput != 0)
        {
            transform.localScale = new Vector3(horizontalInput * (-0.45f), transform.localScale.y, transform.localScale.z);
        }
    }

    private void keyMove()
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
    }
    
    private void touchMove()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.position.x > (maxWidth / 2.0f))
            {
                rb.velocity = new Vector2(1 * moveSpeed, rb.velocity.y);
                // �Ͻ������϶� ��� ����
                if (GameManager.instance.gameover) return;
                transform.localScale = new Vector3(1 * (-0.45f), transform.localScale.y, transform.localScale.z);
            }
            else if (touch.position.x < (maxWidth / 2.0f))
            {
                rb.velocity = new Vector2(-1 * moveSpeed, rb.velocity.y);
                // �Ͻ������϶� ��� ����
                if (GameManager.instance.gameover) return;
                transform.localScale = new Vector3(-1 * (-0.45f), transform.localScale.y, transform.localScale.z);
            }
        }
    }
}