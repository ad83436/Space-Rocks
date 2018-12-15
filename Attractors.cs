using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Attractors : MonoBehaviour {
    public Rigidbody2D star;

    public int G;
    public Rigidbody2D Player;
 
    public Vector2 forceOfGravity;
    public Vector2 Direction;
    public float Distance;
    public float magForceofGravity;

    float myTime = 0;




    void Start()
    {
        Player.GetComponent<Rigidbody2D>();
        star = GameObject.FindWithTag("Star").GetComponent<Rigidbody2D>();
       

        PlayerController player = Player.GetComponent<PlayerController>();

      
        star.gravityScale = G;
        

    }
     void FixedUpdate()
     {


        PlayerController player = Player.GetComponent<PlayerController>();
 
            Gravity();

        
        

         

        




     }

    private void OnTriggerEnter2D(Collider2D col)
    {


        if (col.gameObject.tag.Equals("Respawn"))
        {

            Destroy(col.gameObject);

        }
      
        if (col.gameObject.tag.Equals("Player"))
        {

            Destroy(col.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            myTime = 0;
        }




    }

    void Gravity()
    {

        star.GetVector(Direction);
        Direction = (star.position - Player.position);
        star.GetComponent<Rigidbody2D>().GetVector(Direction); 
        Distance = Direction.magnitude;
        if (Distance == 0)
        {
            return;
        }
        magForceofGravity = G * (Player.mass * star.mass) / (Distance * Distance);
        forceOfGravity = Direction.normalized * magForceofGravity;

        Player.AddForce(forceOfGravity);

    }
   


    



} 
