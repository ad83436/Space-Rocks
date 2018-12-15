using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundscroll : MonoBehaviour {

    Material material;

    Vector2 offSet;

    public float xVelocity, yVelocity;

    private void Awake(){
        material = GetComponent<Renderer>().material;
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        offSet = new Vector2(xVelocity, yVelocity);
        material.mainTextureOffset += offSet * Time.deltaTime;
	}
}
