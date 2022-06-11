using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Atributos
    [SerializeField] private int   life;
    [SerializeField] private float velocity;
    [SerializeField] private float force;
    [SerializeField] private bool  live;
    [SerializeField] private bool  stunned;

    //Componentes auxiliares
    private Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Joystick
        if (Input.GetKey("a")) Left();
        if (Input.GetKey("d")) Right();
        if (Input.GetKeyDown("space")) Jump();
    }

    public void Left()
    {
        HorizontalWalk(-Velocity);
    }

    //Pulo
    public void Jump()
    {
        ForceTo(transform.up * Force);
    }

    private void ForceTo(Vector2 v)
    {
        rigidBody2D.AddForce(v, ForceMode2D.Impulse);
    }

    //Movimentação horizontal
    public void Right()
    {
        HorizontalWalk(Velocity);
    }

    private void HorizontalWalk(float velocity)
    {
        //transform.Translate(Time.deltaTime * velocity, 0, 0);
        transform.position += transform.right * Time.deltaTime * velocity;
    }


    //Métodos acessores (GETTERS E SETTERS)
    public int Life
    {
        get { return this.life;  }
        set { this.life = value; }
    }

    public float Velocity
    {
        get { return this.velocity; }
        set { this.velocity = value; }
    }

    public float Force
    {
        get { return this.force; }
        set { this.force = value; }
    }

    public bool Live
    {
        get { return this.live; }
        set { this.live = value; }
    }

    public bool Stunned
    {
        get { return this.stunned; }
        set { this.stunned = value; }
    }
}
