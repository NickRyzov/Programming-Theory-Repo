using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSphere : Shape
{
    float[] size = {0.5f,0.75f, 1, 1.25f, 1.5f};
    int num = 2;

    public override void Start()
    {
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
    }
    
}
