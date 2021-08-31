using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSphere : Shape
{
    float[] size = {0.4f,0.8f, 1.2f, 1.6f, 2f};
    //int num = 2;

    public override void Start()
    {
        num = 2;
        SetScale(num);
        base.Start();
    }


    void SetScale (int n)
    {
        transform.localScale = new Vector3(size[n], size[n], size[n]);
    }

    public override void ChangeParam()
    {
        int n;
        do
        {
            n = Random.Range(0, size.Length);
        }
        while (n == num);
        SetScale(n);
        num = n;
        gF.CheckWinConditions();
    }
    
}
