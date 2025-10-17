using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 3f;
    public bool isTouchRight;
    public bool isTouchLeft;

    public float MaxShootDelay;
    public float NowShootDelay;

    public GameObject bulletObj;
    
    void FixedUpdate()
    {
        Move();
        Fire();
    }

    void Move()
    {
        // 좌우 버튼을 눌렀을 때
        float h = Input.GetAxisRaw("Horizontal");
        if ((isTouchRight && h == 1) || (isTouchLeft && h == -1))
            h = 0;

        // 위치 이동
        Vector2 nowPos = transform.position;
        Vector2 afterPos = new Vector2(h, 0) * Speed * Time.deltaTime;
        transform.position = nowPos + afterPos;
    }

    void Fire()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bulletObj, transform.position, Quaternion.identity);
        }
    }
}