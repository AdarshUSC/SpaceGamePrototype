using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    // public Rigidbody2D rb;
    public Button PButton; // PowerUp Button  in the unity game
    public float slowDownMultiplier = 0.5f; 

    void Start()
    {

        if (PButton != null)
        {
            PButton.onClick.AddListener(StopEnemyVehicles);
        }
        else
        {
            Debug.LogError("PButton is not assigned in the Inspector.");
        }
    }
    void Update()
    {
        
    }

    void StopEnemyVehicles()
    {

        GameObject[] enemyVehicles = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemyVehicle in enemyVehicles)
        {
            Rigidbody2D enemyRigidbody = enemyVehicle.GetComponent<Rigidbody2D>();
            if (enemyRigidbody != null)
            {
                // Slowing down the enemy vehicle
                enemyRigidbody.velocity *= slowDownMultiplier;
            }
        }
    }

    // Collision handling
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //
    //     // Destroying the PowerUp GameObject
    //     Destroy(gameObject);
    //     // Applying the power-up effect to the collided object
    //     powerupEffect.Apply(collision.gameObject);
    // }
}





