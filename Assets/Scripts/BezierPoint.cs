using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierPoint : MonoBehaviour
{
    private void OnMouseDrag()
    {
        // 스크린 스페이스의 클릭 지점으로 월드 스페이스의 공산에서의 위치 이동을 시켜야 하는 상황.
        // 스크린 스페이스의 클릭 지점이 월드 스페이스에서는 어느 위치린지 전환처리를 해야 한다.
        Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPoint.z = 0f;
        transform.position = mouseWorldPoint;
    }

    public void btnDelete()
    {
        Destroy(gameObject);
    }
}
