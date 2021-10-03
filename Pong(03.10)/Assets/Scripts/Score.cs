using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Херня для работы с текстовой херней

public class Score : MonoBehaviour
{
    public static int scoreAmount; // Хранить колличество очков
    Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;
        scoreText.text = "";
    }

   
    void Update()
    {
        if (scoreText.text == "10")
        {
            scoreAmount = 0;
            scoreText.text = "" + scoreAmount;
        }
        scoreText.text = ""+scoreAmount;
    }
}
