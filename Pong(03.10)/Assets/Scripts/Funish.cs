using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Херня для работы с текстовой херней. А именно текс

public class Funish : MonoBehaviour
{
    // Start is called before the first frame update
    Text scoreText;
    public string winer="";
    void Start()
    {
      scoreText = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Score.scoreAmount == 10)
        {
            winer = "Победил Белый игрок\n Для повтора нажмите Esc";
            scoreText.text = winer;
        }
        if (Score2.scoreAmount2 == 10)
        {
            winer = "Победил Желтый игрок\n Для повтора нажмите Esc";
            scoreText.text = winer;
        }
        if (!Ball.paused)
        {
            winer = "";
            scoreText.text = winer;
        }


    }
}
