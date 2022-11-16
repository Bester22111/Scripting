using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� NPC
    public int Health = 5;

    //������� NPC
    public int Level = 1;

    //�������� NPC
    public float Speed = 1.2f;

    

    // Start is called before the first frame update
    void Start()
    {
        //��������� Health
        Health = Health + Level;

        //����� ������
        print("�������� ������ " + Health);

       
    }

    // Update is called once per frame 
    void Update()
    {
        //�������� 
        Vector3 newPosition = transform.position;

        newPosition.x += Speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
 