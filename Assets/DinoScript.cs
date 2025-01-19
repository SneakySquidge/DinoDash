using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool DinoIsAlive = true;
    public ParticleSystem Wind;
    AudioSource wingflap;


    void Start()
    {
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
       wingflap = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && DinoIsAlive == true)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
            CreateWind();
            wingflap.Play();
        }
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(DinoIsAlive)
        {
            logic.gameOver();
            DinoIsAlive = false;
        }
    }
    
    void CreateWind()
    {
        Wind.Play();
    }
}
