using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ComplexSliderTest : MonoBehaviour
{
    public InputField input;
    public Slider slider;
    private string regex = "[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)";
    private Color32 red = new Color32(255, 0, 0, 255);
    private Color32 white = new Color32(255, 255, 255, 255);
    public GameObject obj;


    
    public void change(float f)
    {
        
        input.text = f.ToString();
        //obj.transform.localScale = new Vector3(f, f, f); // pour changer la taiile, decomenter si besoin drag and drop de l'objet directement
        
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
