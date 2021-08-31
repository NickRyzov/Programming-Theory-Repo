using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField]
    protected GameFlow gF;
    public float timeToOvercome;
    public string message;
    public bool refrence;
    Vector3 startPos, finishPos;
    float startTime;
    float sign = 1;

    public virtual void Start()
    {
        GameObject go = GameObject.Find("Canvas");
        gF = go.GetComponent<GameFlow>();
        if (!refrence)
        {
            SetPositions();
        }
    }

    protected void OnMouseDown()
    {
       if (refrence) return;
       ChangeParam();
       gF.DisplayText(message);
    }

    void SetPositions()
    {
        startPos = transform.position;
        finishPos = new Vector3(transform.position.x, transform.position.y + (sign * 5), transform.position.z);
        startTime = Time.time;
        sign *= -1;
        ChangeMovingSpeed();
        ChangeParam();
    }

    void ChangeMovingSpeed ()
    {
        timeToOvercome = Random.Range(4f, 6f);
    }

    public virtual void ChangeParam()
    { }

    private void Update()
    {
        if (refrence) return;
        float u = (Time.time - startTime) / timeToOvercome;
        Vector3 currentPos = (1 - u) * startPos + u * finishPos;
        transform.position = currentPos;
        if (u >= 1)
        {
            SetPositions();
        }
    }


}
