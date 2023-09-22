using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bullet;
    private GameObject player;
    private GameObject mixArea;

    public bool isDectected;
    // Start is called before the first frame update
    void Start()
    {
        isDectected = false;
        player = GameObject.FindGameObjectWithTag("Player");
        mixArea = GameObject.FindGameObjectWithTag("mixArea");
    }

    // Update is called once per frame
    void Update()
    {
        // float distance = Vector2.Distance(transform.position, player.transform.position);
        // Debug.Log(distance);
        if(transform.position.y<-0.8f && transform.position.y>-3.5f && !isDectected && !compareColors(GetComponent<SpriteRenderer>().color, player.GetComponent<SpriteRenderer>().color)){
            Shoot();
            isDectected = true;
        }
        if (transform.position.y < -3.5f)
        {
            FindObjectOfType<ColorMixer>().OnResetClick();
        }
        if (transform.position.y<-6.0f){
            Destroy(this);
        }
    }

    void Shoot(){
        Instantiate(bullet, firePoint.position, Quaternion.identity);
    }

    private bool compareColors(Color color1,Color color2)
    {
        bool match = false;
        if(Mathf.Abs(color1.r-color2.r)<0.005 & Mathf.Abs(color1.g-color2.g)<0.005 & Mathf.Abs(color1.b - color2.b) < 0.005)
        {
            match = true;
        }
        return match;
    }


   
}
