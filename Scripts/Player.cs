using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private int   life;
    [SerializeField] private float velocity;
    [SerializeField] private float force;
    [SerializeField] private bool  live;
    [SerializeField] private bool  stunned;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Joystick
        if (Input.GetKey("a")) Left();
        if (Input.GetKey("d")) Right();
    }

    public void Left()
    {
        HorizontalWalk(-Velocity);
    }

    //Movimentação horizontal
    public void Right()
    {
        HorizontalWalk(Velocity);
    }

    private void HorizontalWalk(float velocity)
    {
        transform.Translate(Time.deltaTime * velocity, 0, 0);
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
