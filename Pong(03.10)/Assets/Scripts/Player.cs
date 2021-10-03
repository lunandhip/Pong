using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D regidbody; //
    public float speed; // Переменная
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame // Update вызываеться 1 раз за кадр
    void Update() // то что поисходит каждый кадр.
    {
        Vector2 direction = Vector2.zero; // direction название переменной. После отпуска кнопки перемещения скорость сохраняеться.
        if (Input.GetKey(KeyCode.W)) //В нашем случае нажатие GetKey-получить кнопку.
        {
            
            direction = Vector2.up * speed; // нажимая кнопку мы умножаем на значение вектора

        }
        if (Input.GetKey(KeyCode.S)) // Тоже смое но для кнопки S
        {
           
            direction = Vector2.down * speed;

            
        }
        regidbody.velocity = direction * speed; // когда кнопка не нажата вектор движения становиться равен 0.
    }
}
