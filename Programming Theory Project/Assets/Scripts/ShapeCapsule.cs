using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class ShapeCapsule : Shape
{
    Vector3[] angles =
        { new Vector3(45,45, 60), new Vector3(10, 50, 45), new Vector3(233, 75, 45),
        new Vector3 (120,160,20),  new Vector3(150,45,45), new Vector3(15,15,29),
        new Vector3 (225,90,89), new Vector3 (155,45,80), Vector3.zero};


    // POLYMORPHISM
    public override void Start()
    {
        //меняем стартовую позиции для целевых форм, так как обычные и так рендомизируются
        if (refrence) num = FindNum();
        SetAngles(num);
        base.Start();
    }

    void SetAngles (int n)
    {
        transform.rotation = Quaternion.Euler(angles[n]);
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
        SetAngles(n);
        num = n;
        gF.CheckWinConditions();
    }
}
