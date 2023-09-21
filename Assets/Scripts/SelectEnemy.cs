using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            enemyColor = renderer.color;
            Color mixedColor = FindObjectOfType<ColorMixer>().resultColor;
            //Debug.Log(mixedColor + "" + enemyColor + "" + mixedColor.Equals(enemyColor));
            if (!compareColors(enemyColor, mixedColor))
            {
                if (transform.position.y <= -5)
                {
                    Debug.Log("you lose!");
                    Application.Quit();
                }
            }
        }
        
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
