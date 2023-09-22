using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// text mesh pro 
public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update

    public static int scoreValue = 0;
    public TMP_Text score;
    void Start()
    {
       score = GetComponent<TMP_Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score.SetText("Score : " + scoreValue);
       // Debug.Log(scoreValue);
    }
}
