using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSquare : Shape
{
    public Color [] colors;
    public string[] namesOfColor;
    Material material;
    int num = 0;

    public override void Start()
    {
        base.Start();
        material = GetComponent<MeshRenderer>().material;
    }

    public override void OnMouseDown()
    {
        int n;
        do
        {
            n = Random.Range(0, colors.Length);
        }
        while (n == num);
        material.color = colors[n];
        message = namesOfColor[n]+" Square";
        num = n;
        base.OnMouseDown();
    }
}
