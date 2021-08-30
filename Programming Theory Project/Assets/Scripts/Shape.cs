using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField]
    protected GameFlow gF;
    public float timeToOvercome;
    public string message;
    Vector3 startPos, finishPos;
    float startTime;
    float sign = 1;

    public virtual void Start()
    {
        GameObject go = GameObject.Find("Canvas");
        gF = go.GetComponent<GameFlow>();
        SetPositions();
    }

    public virtual void OnMouseDown()
    {
       gF.DisplayText(message);
    }

    void SetPositions()
    {
        startPos = transform.position;
        finishPos = new Vector3(transform.position.x, transform.position.y + (sign * 4), transform.position.z);
        startTime = Time.time;
        sign *= -1;
        ChangeMovingSpeed();
    }

    void ChangeMovingSpeed ()
    {
        timeToOvercome = Random.Range(1, 2.5f);
    }

    private void Update()
    {
        float u = (Time.time - startTime) / timeToOvercome;
        Vector3 currentPos = (1 - u) * startPos + u * finishPos;
        transform.position = currentPos;
        if (u >= 1) SetPositions();
    }


}
