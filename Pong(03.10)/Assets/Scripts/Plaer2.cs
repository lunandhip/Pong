using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaer2 : MonoBehaviour
{
    public Rigidbody2D regidbody2; // Создаем ссылку на компонет элеманта. Нахрена?
    public float speed; //Создаем переменную для хранения скорости
    void Start()
    {
        
    }
    void Update()
    {
        Vector2 direction = Vector2.zero;
        if(Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector2.up * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down * speed;
        }
        regidbody2.velocity = direction * speed;
    }
}
