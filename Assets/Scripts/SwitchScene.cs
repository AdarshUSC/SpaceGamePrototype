using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour
{
    public Button playButton;
    // Start is called before the first frame update
    void Start()
    {
        // playButton.onClick.AddListener(PlayGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        // Load the gameplay scene when the play button is clicked.
        SceneManager.LoadScene("GameScene");
    }
}
