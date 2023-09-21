using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bullet;

    private GameObject player;

    public bool isDectected;
    // Start is called before the first frame update
    void Start()
    {
        isDectected = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        // Debug.Log(distance);
        if(distance<4.5 && !isDectected){
            Shoot();
            isDectected = true;
        }
    }

    void Shoot(){
        Instantiate(bullet, firePoint.position, Quaternion.identity);
    }


   
}
