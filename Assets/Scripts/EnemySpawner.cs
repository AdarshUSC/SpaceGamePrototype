using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update

    // static Random random = new Random();
    public float spawnRate = 20.0f;

    public GameObject enemyPrefab;

    [SerializeField] bool canSpawn = true;
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner() {

        
        Color[] colorArr = {new Color(115.0f/255,72.0f/255,140.0f/255,1), new Color(237.5f/255,111.0f/255,23.5f/255,1), new Color(0,0,0,1), new Color(55.0f/255,199.0f/255,163.0f/255,1), new Color(10.0f/255,100.0f/255,10.0f/255,1) };

        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        
        float speedIncrementor = 0;
        float currentSpeed = 0;

        while(canSpawn){
            yield return wait;
            GameObject enemyObject1 = Instantiate(enemyPrefab, new Vector3(-3.0f, 8.3f, 204.4f), Quaternion.identity);
            GameObject enemyObject2 = Instantiate(enemyPrefab, new Vector3(3.0f, 8.3f, 204.4f), Quaternion.identity);
            int randomIndex = Random.Range(0, colorArr.Length);
            Debug.Log(randomIndex+" "+colorArr[randomIndex]);
            enemyObject1.GetComponent<SpriteRenderer>().color = colorArr[randomIndex];
            enemyObject2.GetComponent<SpriteRenderer>().color = colorArr[randomIndex];
            // Rigidbody rb = enemyObject.GetComponent<Rigidbody>();
            // currentSpeed = enemyObject.GetComponent<Rigidbody>().velocity.magnitude + speedIncrementor;
            // rb.AddForce(0,new Vector3(currSpeed),0, ForceMode.VelcoityChange);
            // speedIncrementor+=.5f;
            if(enemyObject1.transform.position.y<-6.0f){
                Destroy(enemyObject1); 
            } if(enemyObject2.transform.position.y<-6.0f){
                Destroy(enemyObject2); 
            }
        }
    }

}
