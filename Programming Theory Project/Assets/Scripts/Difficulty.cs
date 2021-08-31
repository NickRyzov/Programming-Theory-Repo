using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public static Difficulty instance { get; private set; }//Снаружи можно читать внутри можно читать и записывать
    public int dLevel { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetDifficulty(int n)
    {
        dLevel = n;
    }
}
