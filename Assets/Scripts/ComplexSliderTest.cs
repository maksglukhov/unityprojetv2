using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System;

public class ComplexSliderTest : MonoBehaviour
{
    public InputField input;
    public Slider slider;
    public Slider sliderR;
    public Slider sliderG;
    public Slider sliderB;
    public Slider sliderX;
    public Slider sliderY;
    private string regex = "[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)";
    private Color32 red = new Color32(255, 0, 0, 255);
    private Color32 white = new Color32(255, 255, 255, 255);
    public GameObject obj;


    
    public void change(float f)
    {
        
        input.text = f.ToString();
        //obj.transform.localScale = new Vector3(f, f, f); // pour changer la taiile, decomenter si besoin et drag and drop de l'objet directement
        
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

    public void ChangeColorR(float f)
    {
        Image image = obj.GetComponent<Image>();
        byte current = Convert.ToByte(f);
        byte green = Convert.ToByte(sliderG.value);
        byte blue = Convert.ToByte(sliderB.value);
        image.color = new Color32(current, green, blue, 255);
    }



    public void ChangeColorG(float f)
    {
        Image image = obj.GetComponent<Image>();
        byte current = Convert.ToByte(f);
        byte red = Convert.ToByte(sliderR.value);
        byte blue = Convert.ToByte(sliderB.value);
        image.color = new Color32(red, current, blue, 255);
    }

    public void ChangeColorB(float f)
    {
        Image image = obj.GetComponent<Image>();
        byte current = Convert.ToByte(f);
        byte green = Convert.ToByte(sliderG.value);
        byte red = Convert.ToByte(sliderR.value);
        image.color = new Color32(red, green, current, 255);
    }

    public void ChangePosX(float f)
    {
        float y = sliderY.value;
        obj.transform.position = new Vector2(f, y);
    }

    public void ChangePosY(float f)
    {
        float x = sliderX.value;
        obj.transform.position = new Vector2(x, f);
    }



}
