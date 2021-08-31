using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class ShapeSquare : Shape
{
    public Color [] colors;
    public string[] namesOfColor;
    Material material;

    // POLYMORPHISM
    public override void Start()
    {
        if (refrence) num = FindNum();
        material = GetComponent<MeshRenderer>().material;
        SetColor(num);
        base.Start();
    }

    // POLYMORPHISM
    public override void ChangeParam()
    {
        int n;
        do
        {
            n = FindNum();
        }
        while (n == num);
        SetColor(n);
        message = namesOfColor[n] + " Square";
        num = n;
        gF.CheckWinConditions();
    }

    void SetColor(int n)
    {
        material.color = colors[n];
    }
}
