using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Херня для работы с текстовой херней

public class Score2 : MonoBehaviour
{
    public static int scoreAmount2; // Хранить колличество очков
    Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount2 = 0;
        scoreText.text = "";
    }


    void Update()
    {
        if (scoreText.text == "10")
        {
            scoreAmount2 = 0;
            scoreText.text = "" + scoreAmount2;
        }
        scoreText.text = "" + scoreAmount2;
    }
}
