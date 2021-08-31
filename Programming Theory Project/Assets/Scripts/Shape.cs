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
    
    public int num { get; protected set; }

    public virtual void Start()
    {
        GameObject go = GameObject.Find("Canvas");
        gF = go.GetComponent<GameFlow>();
        if (!refrence)
        {
            SetPositions();
        }
    }

    protected int FindNum()
    {
        int n;
        //максимальная сложность
        if (Difficulty.instance.dLevel== 2)
        {
            return n = Random.Range(0, 9);
        }
        else
        {
            return n = Random.Range(0, 5);
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
        //Возможная скорость перемещения формы задается лимитами определяемыми выбранной сложностью
        timeToOvercome = Random.Range(gF.SPEED_LIMITS[Difficulty.instance.dLevel].x,
            gF.SPEED_LIMITS[Difficulty.instance.dLevel].y);
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
