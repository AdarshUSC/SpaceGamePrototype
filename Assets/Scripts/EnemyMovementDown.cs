using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 25.0f;
    void Start()
    {   
        // GameObject bullet = new GameObject.renderer();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}
