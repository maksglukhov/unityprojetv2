using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ComplexSliderTest : MonoBehaviour
{
    private int sliderInt;
    private string inputString;
    public InputField input;
    public Slider slider;
    private string regex = "[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)";
    private Color32 red = new Color32(255, 0, 0, 255);
    private Color32 white = new Color32(255, 255, 255, 255);

    public void change(float f)
    {
        //inputString = i.ToString();
        input.text = f.ToString();
        //GameObject.transform.localScale = new Vector3(f, f, f);
        
    }

    public void change(string s)
    {
        Image image = input.GetComponent<Image>();
        if (System.Text.RegularExpressions.Regex.IsMatch(s, regex))
        {
            image.color = white;
            slider.value = float.Parse(s);
        }
        else
        {
            image.color = red;
        }

    }





}
