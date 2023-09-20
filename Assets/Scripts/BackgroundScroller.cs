using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollSpeed = 2.0f;
    private float offset;
    private Material mat;

    private Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*scrollSpeed*Time.deltaTime);
        if(transform.position.y < -14.36f){
            transform.position = startPosition;
        }
    }
    
}
