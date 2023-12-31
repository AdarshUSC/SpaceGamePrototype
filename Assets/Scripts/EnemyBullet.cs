using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    public Rigidbody2D rb;
    public float force;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity  = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot+270);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.CompareTag("Player")){
            Destroy(gameObject);
            SceneManager.LoadScene("EndScene");
            // PlayerPrefs.SetString("finalScore",ScoreScript.scoreValue);
        }
    }
}
