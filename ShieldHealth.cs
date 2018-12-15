using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShieldHealth : MonoBehaviour {
    public static int sShieldHealth = 10;

    Text shieldHealth;
	// Use this for initialization
	void Start () {
        shieldHealth = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        shieldHealth.text = "Shield Health :" + sShieldHealth;
	}
}
