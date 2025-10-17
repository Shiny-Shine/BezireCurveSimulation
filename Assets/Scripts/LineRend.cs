using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRend : MonoBehaviour
{
    private LineRenderer line; // trailer
    private GameObject _poi; // Object to be trail
    private List<Vector3> points; // List for saving points
    // Start is called before the first frame update
    void Awake()
    {


        //Disable the LineRenderer until it's need.
        line = GetComponent<LineRenderer>();
        line.enabled = false;

        points = new List<Vector3>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
