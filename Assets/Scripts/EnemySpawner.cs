using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public float spawnRate = 5.0f;

    public GameObject enemyPrefab;

    [SerializeField] bool canSpawn = true;
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner() {

    
        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        
        float speedIncrementor = 0;

        while(canSpawn){
            yield return wait;
            GameObject enemyObject = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            // enemyObject.velocity.magnitude+=speedIncrementor;
            speedIncrementor+=.5f;
            if(enemyObject.transform.position.y<-6.0f){
                Destroy(enemyObject);
            }

           // spawnRate
        }
    }

}
