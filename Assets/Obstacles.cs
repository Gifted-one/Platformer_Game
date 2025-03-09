using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    Rigidbody2D platform;
    float delay = 0;
    public int Delay_int = 0;
    public int change;
    public int direction;
    bool status;
    int speed;

   
    void Start()
    {
        platform = GetComponent<Rigidbody2D>();
        direction = 1;
        status = false;
        change = Random.Range(4, 1);
        speed = Random.Range(1, 5);

    }

   
    void Update()
    {
        delay += Time.deltaTime;
        Delay_int = (int)delay;


        if(Delay_int % change != 0)
        {
            status = true;
        }
        if(Delay_int % change == 0 )
        {
            
            if(status)
            {
                direction *= -1;
                status = false;
            }
            platform.velocity = new Vector2 (speed * direction, 0);
        }
    }
}
