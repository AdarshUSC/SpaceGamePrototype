using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update

    // static Random random = new Random();
    public float spawnRate = 4.0f;
    public GameObject enemyPrefab;

    // public ArrayList<GameObject> enemyArray = new ArrayList<GameObject>();

    [SerializeField] bool canSpawn = true;
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner() {

        
        Color[] colorArr = {new Color(115.0f/255,72.0f/255,140.0f/255,1), new Color(238.0f/255,111.0f/255,23.0f/255,1), new Color(0,0,0,1), new Color(55.0f/255,199.0f/255,163.0f/255,1), new Color(10.0f/255,100.0f/255,10.0f/255,1) };

        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        // float spawnRateDecrementor = 0.5f;
        GameObject enemyObject1 = Instantiate(enemyPrefab, new Vector3(-1.5f, 8.3f, 204.4f), Quaternion.identity);
        GameObject enemyObject2 = Instantiate(enemyPrefab, new Vector3(1.5f, 8.3f, 204.4f), Quaternion.identity);
        int randomIndex = Random.Range(0, colorArr.Length);
            // Debug.Log(randomIndex+" "+colorArr[randomIndex]);
        enemyObject1.GetComponent<SpriteRenderer>().color = colorArr[randomIndex];
        enemyObject2.GetComponent<SpriteRenderer>().color = colorArr[randomIndex];

        while(canSpawn){
            yield return wait;
            enemyObject1 = Instantiate(enemyPrefab, new Vector3(-1.5f, 8.3f, 204.4f), Quaternion.identity);
            enemyObject2 = Instantiate(enemyPrefab, new Vector3(1.5f, 8.3f, 204.4f), Quaternion.identity);
            randomIndex = Random.Range(0, colorArr.Length);
            // Debug.Log(randomIndex+" "+colorArr[randomIndex]);
            enemyObject1.GetComponent<SpriteRenderer>().color = colorArr[randomIndex];
            enemyObject2.GetComponent<SpriteRenderer>().color = colorArr[randomIndex];
            //trying to increase speed of incoming spaceships eventually
            // Rigidbody rb = enemyObject.GetComponent<Rigidbody>();
            // currentSpeed = enemyObject.GetComponent<Rigidbody>().velocity.magnitude + speedIncrementor;
            // rb.AddForce(0,new Vector3(currSpeed),0, ForceMode.VelcoityChange);
            // speedIncrementor+=.5f;
            // spawnRate-=spawnRateDecrementor;
        }
    }

}
