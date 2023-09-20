using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorMixer : MonoBehaviour
{
    public Button button0;
    public Button button1;
    public Button button2;

    public SpriteRenderer mixingArea;
    public SpriteRenderer spaceship;
    public SpriteRenderer enemyShip;
    
    //private Color selectedColor1 = GetComponent<Button> ().colors; // Initial color
    private List<Color> colorList = new List<Color>();
    private bool buttonSelected = false;
    private Color buttonColor;
    public static Color CombineColors(params Color[] aColors)
    {
        Color result = new Color(0,0,0,0);
        foreach(Color c in aColors)
        {
            result += c;
        }
        result /= aColors.Length;
        return result;
    }

    // Start is called before the first frame update
    private void Start()
    {
        button0.onClick.AddListener(() => OnButtonClick(button0));
        button1.onClick.AddListener(() => OnButtonClick(button1));
        button2.onClick.AddListener(() => OnButtonClick(button2));
        Debug.Log(enemyShip.color);
    }

   

    private void OnButtonClick(Button clicked)
    {   
        //buttonSelected = !buttonSelected;
        clicked.interactable = false; //disable the button so player cannot click twice
        buttonColor = clicked.GetComponent<Image>().color;
        colorList.Add(buttonColor);
        UpdateOutputColor();
        //clicked.GetComponent<Image>().color *= new Color((float)0.78,(float)0.78,(float)0.78,(float)0.5);            
        

    }

    private void UpdateOutputColor()
    {
        Color[] selectedColors = colorList.ToArray();
        Color resultColor = CombineColors(selectedColors);
        mixingArea.color = resultColor;
        spaceship.color = resultColor;
    }

}
