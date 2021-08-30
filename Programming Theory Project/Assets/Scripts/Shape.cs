using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField]
    protected GameFlow gF;
    public string message;

    public virtual void Start()
    {
        GameObject go = GameObject.Find("Canvas");
        gF = go.GetComponent<GameFlow>();
    }

    public virtual void OnMouseDown()
    {
        if (gF == null)
        {
            print("error");
        }
        else
        {
            gF.DisplayText(message);
        }
    }

}
