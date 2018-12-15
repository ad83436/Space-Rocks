using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    private Transform Bullet;
    public Transform player;
    public float BulletSpeed;
   public Vector3 pointOfOrigin;
   

	// Use this for initialization
	void Start () {
        Bullet = GetComponent<Transform>();
        player = GameObject.Find("Player").GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {
        Bullet.position +=  Vector3.up * BulletSpeed;
        pointOfOrigin = player.position;

        if (Bullet.position.y >= pointOfOrigin.y + 8.0f) 
            Destroy(gameObject);
        	
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Respawn"))
        {
            ScoreScript.ScoreValue += 1;
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }




}


