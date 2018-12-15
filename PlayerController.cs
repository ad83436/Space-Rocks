using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Transform player;
    public float speed;
    public float maxBoundx, minBoundx;
    public float maxBoundy, minBoundy;
    public GameObject StarDestroyer; 
    public GameObject shot;
    public Transform shotSpawn;
    public Transform StarDestroyerSpawn; 
    public float fireRate;
   
    private float nextFire;
    public int numberOfDestroyers;
    public int targetScore;
    public float h;
    public float V;



    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
       
        StarDestroyerSpawn = GetComponent<Transform>();
        
     

    }

    // Update is called once per frame
   public void FixedUpdate(){
       
        h = Input.GetAxis("Horizontal");
       V = Input.GetAxis("Vertical");

        if (player.position.x < minBoundx && h < 0)
            h = 0;

        else if (player.position.x > maxBoundx && h > 0)
            h = 0;

        player.position += Vector3.right * h * speed;

        if (player.position.y < minBoundy && V < 0)
            V = 0;
        else if (player.position.y > maxBoundy && V > 0)
            V = 0;

        player.position += Vector3.up * V * speed;




        numberOfDestroyers = 0;
        targetScore = 10;
       
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire){
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
     

        
      
        
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
           if (col.gameObject.tag.Equals("Respawn")){
            ShieldHealth.sShieldHealth = 10;
            ScoreScript.ScoreValue = 0;
            Destroy(col.gameObject);
            Destroy(gameObject);
            
            
            }
    }

}




 
