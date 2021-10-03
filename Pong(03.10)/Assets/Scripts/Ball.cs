using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour 
{
    public Rigidbody2D regidbody; // Получаем доступ к телу
    public float speed; //Создаем переменую для скорости
    public Vector2 direction; // Вектор для задания направления шарика
    public float baseSpeed; //Переменная для ускорения, храми базовую скоорость.
    public float coefficientSpeed; // Множитель скорости
    public int points; //Хранит число ударов об ракетку
    public Player player; // создаем ссылку на компонет плеер
    int score1;
    int score2;
    int Score_Player; // Переменная для подсчета очков
    int funal; // Переменная считающая когда игра все
    public static bool paused = false; // Переменная для паузы
    public GameObject panel;// Кнопка для паузы

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector2.zero;
        //transform.position = Vector2.zero; // задаем начальное положение чтобы когда шарик улете за грань он снова появился здесь
        direction = new Vector2(Random.Range(-0.5f, 0.7f), Random.Range(-0.7f,0.5f)); // Задаем рандомное нарпавление для старта шарика. Он потетитт в рандомном наравлении продикторванные x и y. f дает понять юинит что используетсья флоат число.
        //direction = new Vector2(Random.Range(-0.5f, 1), Random.Range(0.5f, -1));
        //speed = baseSpeed;
        speed = 5;
        score1 = 0; //При старте игры значение переменных считающих значение равно 0
        score2 = 0;//При старте игры значение переменных считающих значение равно 0
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Score.scoreAmount == 10 || Score2.scoreAmount2 == 10)
            {
                
                    Time.timeScale = 0;
                    paused = true;
                    panel.SetActive(true);
                
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                //Funish.winer = "";
                Time.timeScale = 1;
                paused = false;
                panel.SetActive(false);
        
            }
        }
        regidbody.velocity = direction.normalized * speed; // Чтобы не выходил за границы возможного числового значения
        
    }
    private void OnCollisionEnter2D(Collision2D col) // Срабатывает когда обьект с бокс коллидер сталкиваеться с другим кбокс коллидеро col-переменная куда это пережаеться
    {
        if (col.gameObject.CompareTag("Player")) // Здесь Player это название тега
        {
            direction.x = -direction.x; // когда шарик соприкоснеться с ракеткой он изменит свое знгачение х на противоположное
            speed = speed * coefficientSpeed; // при соприкосновении с ракеткой скорсоть мячика возрастает. Скорость умножаеться на множитель который мы тоже указываем с клавиатуры
            //points = points + 1; 
            points++;
            
        }
        if (col.gameObject.CompareTag("Respawn")) // Правая палочка твикс
        {

            //transform.position = Vector2.zero;
            score1++;
            Debug.Log("Белый игрок- "+score1);
            Score.scoreAmount += 1; // Переменная для подсчета очков
            Start(); // Чтобы игра началась заново. Мы вызываем срабатывание блока старт.
        }
        if (col.gameObject.CompareTag("Respawn2"))// Левая палочка твикс
        {
            //transform.position = Vector2.zero;
            score2++;
            Debug.Log("Желтый игрок- " + score2);
            Score2.scoreAmount2 += 1; // Переменная для подсчета очков
            Start(); // Чтобы игра началасm заново. Мы вызываем срабатывание блока старт? Без него 
        }
        if (col.gameObject.CompareTag("TopWall"))
        {
            direction.y = -direction.y;
        }
        if (col.gameObject.CompareTag("BottomWall")) // столкновение с обьектом класса
        {
            direction.y = -direction.y; //При столкновении ось y меняеться на проитвоположное
        }
        if (col.gameObject.CompareTag("SideWall"))
        {
            direction.x = -direction.x;
        }
    }
}
