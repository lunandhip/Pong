using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D regidbody; // Rigidbody2-это тип переменной regidbody-нзвание переменной public-отвечает будет ли переменная видна в Юнити. В юнити на него нужно претащить компонет реджид боди
    public float speed; // Переменная
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame // Update вызываеться 1 раз за кадр
    void Update() // то что поисходит каждый кадр. кнопки размещаються имено тут потому что нужно проверять это дерьмо 60 раз в секунду
    {
        Vector2 direction = Vector2.zero; // direction название переменной. После отпуска кнопки перемещения скорость сохраняеться. Т.к этой перменной мы задааем ей скорость но не где ее не убираем. zero есть ее значение.Мы создаем вектор direction и задаем ему нуливое направление
        if (Input.GetKey(KeyCode.W)) //Input-означат ввод. В нашем случае нажатие GetKey-получить кнопку. В кавычках укахываеться что это за кнопка.
        {
            //regidbody.velocity = new Vector2(0, 1); //Образаемся к компонету velocity regidbody он отвечает за перемещение обьекта в пространстве. Vector2 задаем смещение. нужно задать обе коржинаты в формате(x,y)
            //regidbody.velocity = Vector2. up *speed; // анналогична верхней. Домнажаем на переменную которая ускоряет 
            direction = Vector2.up * speed; // нажимая кнопку пы умножаем на значение вектора

            //Debug.Log("Пользователь нажал на кнопку W");// сообщение для окна дебага
        }
        if (Input.GetKey(KeyCode.S)) // Тоже смое но для кнопки S
        {
            //regidbody.velocity = new Vector2(0, -1); // Тоже самое но вниз
            //regidbody.velocity =Vector2. down *speed; // анналогична верхней.Домнажаем на переменную которая ускоряет 
            direction = Vector2.down * speed;

            //Debug.Log("Пользолватель нажал на кнопку S"); // окно для консоли
        }
        regidbody.velocity = direction * speed; // когда кнопка не нахата вектор движения становиться равен 0.Без нее чет нихрена на работает. мозможно потому что нет ссылки на компонет велосити
    }
}
