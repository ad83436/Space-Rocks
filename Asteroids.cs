using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Asteroids : MonoBehaviour {
    public GameObject particles;
    public Transform particless;
    private Transform Asteroid;
    public float fallspeed;
    

	// Use this for initialization
	void Start () {
        Asteroid = GetComponent<Transform>();
        
	}
	
	// Update is called once per frame
	void Update () {
        Asteroid.position += Vector3.up * fallspeed;
        if (Asteroid.position.y <= -15)
            Destroy(gameObject);

        if (GameObject.FindWithTag("Player") == null){

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
       
    }
