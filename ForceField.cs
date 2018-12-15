using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour{
   
    public Transform forcefield;
    
    public Transform player;
    
    void Start()
    {
         
            forcefield.GetComponent<Transform>();
            player.GetComponent<Transform>();

        

    }



    // Update is called once per frame

    void Update()
    {
       if (ShieldHealth.sShieldHealth <= 0)
        {
            Destroy(gameObject);
        }

       forcefield.position = player.position;
     if (forcefield == null)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {


        if (col.gameObject.tag.Equals("Respawn"))
        {
            
            ShieldHealth.sShieldHealth -=  1;
            Destroy(col.gameObject);

        }
        if (col.gameObject.tag.Equals("Star"))
        {
            
            Destroy(gameObject);
        }


    }



