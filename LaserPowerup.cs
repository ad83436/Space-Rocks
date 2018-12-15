using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPowerup : MonoBehaviour {
    private float multiplier = 0.000000001f;
    public float duration;
    public Sprite pic;

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D Laser)
    {
        if (Laser.CompareTag("Player"))
        {
            StartCoroutine(PickUp(Laser));
            Destroy(pic);
        }
    }

    IEnumerator PickUp(Collider2D player)
    {


        PlayerController nextFire = player.GetComponent<PlayerController>();
        nextFire.fireRate *= multiplier;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;


        yield return new WaitForSeconds(duration);

        nextFire.fireRate /= multiplier;

      
        Destroy(gameObject);
    }
    
}
