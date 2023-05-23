using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float HorSpeed;
    public static float speedX;

    Rigidbody2D rb;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Lb()
    {
        speedX = -HorSpeed;
    }

    public void Rb()
    {
        speedX = HorSpeed;
    }

    public void bU()
    {
        speedX = 0;
    }

    private void FixedUpdate()
    {
        transform.Translate(speedX, 0, 0);
    }
}