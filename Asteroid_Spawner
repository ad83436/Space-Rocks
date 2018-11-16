public class AsteroidSpawner : MonoBehaviour
{
    public GameObject Asteroid, Asteroid1, Asteroid2;      
    public float spawnTime = 2f;            // How long between each spawn.
    public float fallSpeed = 40.0f;    //The speed of falling Apples
    private float timer = 0;//counting timer, reset after calling SpawnRandom() function
    private int randomNumber;       //variable for storage of an random Number
    int WhatToSpawn;

    void Update(){
        timer += Time.deltaTime;   // Timer Counter
        if (timer > spawnTime) {
            SpawnRandom();       //Calling method SpawnRandom()
            timer = 0;        //Reseting timer to 0
        }
    }
    public void SpawnRandom(){

        //Creating random Vector3 position
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0,Screen.width), Random.Range(1080, Screen.height), Camera.main.farClipPlane / 2));
        WhatToSpawn = Random.Range(1, 5);
       
        switch (WhatToSpawn){
            case 1:
                Instantiate(Asteroid, screenPosition, Quaternion.identity);
                break;
            case 2:
                Instantiate(Asteroid1, screenPosition, Quaternion.identity);
                break;

            case 3:
                Instantiate(Asteroid2, screenPosition, Quaternion.identity);
                break;
            
        }    
        
                   
    }
}
