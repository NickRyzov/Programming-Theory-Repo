using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    GameFlow gF;
    public string message;

    private void Start()
    {
        GameObject go = GameObject.Find("Canvas");
        gF = go.GetComponent<GameFlow>();
    }

    public virtual void OnMouseDown()
    {
        gF.DisplayText(message);
    }

}
