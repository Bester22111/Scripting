using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    public int Health = 5;

    //Уровень NPC
    public int Level = 1;

    //Скорость NPC
    public float Speed = 1.2f;

    

    // Start is called before the first frame update
    void Start()
    {
        //Изменение Health
        Health = Health + Level;

        //Вывод текста
        print("Здоровье игрока " + Health);

       
    }

    // Update is called once per frame 
    void Update()
    {
        //Движение 
        Vector3 newPosition = transform.position;

        newPosition.x += Speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
 