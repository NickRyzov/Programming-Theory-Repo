using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCapsule : Shape
{
    Vector3[] angles = { new Vector3(45,45, 60), new Vector3(10, 50, 45), new Vector3(233, 75, 45),
        new Vector3 (120,160,20),  new Vector3(150,45,45)};
    

    public override void Start()
    {
        num = 0;
        SetAngles(num);
        base.Start();
    }

    void SetAngles (int n)
    {
        transform.rotation = Quaternion.Euler(angles[n]);
    }

    public override void ChangeParam()
    {
        int n;
        do
        {
            n = Random.Range(0, angles.Length);
        }
        while (n == num);
        SetAngles(n);
        num = n;
        gF.CheckWinConditions();
    }
}
