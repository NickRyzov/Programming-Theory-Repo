using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{
    public Text resultText;
    public GameObject [] rBut;
    //—сылки на ключевые объекты
    public GameObject[] shapesObj;
    Shape[] shapes;

    private void Awake()
    {
        shapes = new Shape[shapesObj.Length];
        for (int i = 0; i< shapesObj.Length; i++)
        {
            shapes[i] = shapesObj[i].GetComponent<Shape>();
        }
    }

    public void CheckWinConditions()
    {
        bool win = true;
        for (int i = 0; i < (shapesObj.Length-1); i += 2)
        {
            if (shapes[i].num != shapes[i + 1].num) win = false;
        }
        if (win)//условие победы выполнено
        {
            //print("Urahh");
            foreach (GameObject go in rBut)
            {
                go.SetActive(true);
            }
            Time.timeScale = 0;
        }
    }

    public void BackToTitleScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void DisplayText(string text)
    {
        resultText.text = text;
    }
}
