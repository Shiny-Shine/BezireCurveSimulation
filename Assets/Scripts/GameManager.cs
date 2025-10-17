using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public GameObject pointPref, pointObj, dotPref, dotObj;
    public BezierCurve dotScr;
    public List<GameObject> objs;

    void Awake()
    {
        if (instance == null)
        {
            //생성 전이면
            instance = this; //생성
        }
        else if (instance != this)
        {
            //이미 생성되어 있으면
            Destroy(this.gameObject); //새로만든거 삭제
        }

        DontDestroyOnLoad(this.gameObject); //씬이 넘어가도 오브젝트 유지
    }

    private void Start()
    {
        objs.Add(GameObject.Find("Point"));
        objs.Add(GameObject.Find("Point (1)"));
    }

    public void btnStart()
    {
        if(dotObj != null)
            Destroy(dotObj);
        dotObj = Instantiate(dotPref, objs[0].transform.position, Quaternion.identity);
        dotScr = dotObj.GetComponent<BezierCurve>();
        dotScr.Curving = true;
        dotScr.time = 0f;
        dotScr.points.Clear();
        foreach (var i in objs)
            dotScr.points.Add(i.transform.position);
    }

    public void btnDelete()
    {
        if (objs.Count <= 2)
            return;
        objs[objs.Count - 1].GetComponent<BezierPoint>().btnDelete();
        objs.RemoveAt(objs.Count - 1);
    }

    public void btnAdd()
    {
        pointObj = Instantiate(pointPref, new Vector3(0f, 0f, 0f), Quaternion.identity);
        pointObj.GetComponentInChildren<TextMeshPro>().text = $"{objs.Count + 1}";
        objs.Add(pointObj);
    }
}