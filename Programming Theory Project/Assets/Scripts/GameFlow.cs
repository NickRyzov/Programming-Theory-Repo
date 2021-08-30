using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{
    public Text resultText;
    public void BackToTitleScene()
    {
        SceneManager.LoadScene(0);
    }

    public void DisplayText(string text)
    {
        resultText.text = text;
    }
}
