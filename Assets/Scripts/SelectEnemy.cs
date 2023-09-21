using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectEnemy : MonoBehaviour
{
    public Color enemyColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        if(renderer.isVisible)
        {
            // Perform the selection logic here.
            Select();
        }
    }
    private void Select()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        if (renderer == null)
        {
            return;
        }
        
        // Get the color property from the material.
        enemyColor = renderer.color;

        // Use the objectColor as needed.
        //Debug.Log("Prefab color: " + enemyColor);
    }
}
