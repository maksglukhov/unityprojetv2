using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Configure : MonoBehaviour
{
    public static Configure inst;
    public GameObject selectedFigure;
    public Slider sliderSize;
    public Slider sliderR;
    public Slider sliderG;
    public Slider sliderB;
    private Color32 red = new Color32(255, 0, 0, 255);

    void Start()
    {
        Configure.inst = this;
    }
    public void setFigure(GameObject figure)
    {
        this.selectedFigure = figure;
        Vector3 localScale = selectedFigure.transform.localScale;
        //slider.value = 1;
        sliderSize.value = localScale.x;
        
        Image image = selectedFigure.GetComponent<Image>();
        Color32 color = image.color;
        sliderR.value = color.r;
        sliderG.value = color.g;
        sliderB.value = color.b;
        Debug.Log("Figure selected");
    }

    public void ChangeSize(float f)
    {

        selectedFigure.transform.localScale = new Vector3(f, f, f);

    }

    public void ChangeColorR(float f)
    {
        Image image = selectedFigure.GetComponent<Image>();
        byte current = Convert.ToByte(f);
        byte green = getIntFromSlider(sliderG);
        byte blue = getIntFromSlider(sliderB);
        image.color = new Color32(current, green, blue, 255);
    }



    public void ChangeColorG(float f)
    {
        Image image = selectedFigure.GetComponent<Image>();
        byte current = Convert.ToByte(f);
        byte red = getIntFromSlider(sliderR);
        byte blue = getIntFromSlider(sliderB);
        image.color = new Color32(red, current, blue, 255);
    }

    public void ChangeColorB(float f)
    {
        Image image = selectedFigure.GetComponent<Image>();
        byte current = Convert.ToByte(f);
        byte green = getIntFromSlider(sliderG);
        byte red = getIntFromSlider(sliderR);
        image.color = new Color32(red, green, current, 255);
    }

    public void ChangeColor()
    {
        Image image = selectedFigure.GetComponent<Image>();

        //image.color = new Color(255,0,0);
    }

    public byte getIntFromSlider(Slider s)
    {
        byte b = Convert.ToByte(s.value);
        return b;
    }

    /*
   
    public void ChangeColorR(float f)
    {
        Image image = selectedFigure.GetComponent<Image>();
        int current = (int)Mathf.RoundToInt(f);
        int green = getIntFromSlider(sliderG);
        int blue = getIntFromSlider(sliderB);
        byte g = Convert.ToByte(green);
        byte b = Convert.ToByte(blue);
        byte c = Convert.ToByte(current);
        image.color = new Color32(c, g, b, 255);
    }
    public void ChangeColorG(float f)
    {
        Image image = selectedFigure.GetComponent<Image>();
        int current = (int)Mathf.RoundToInt(f);
        int red = getIntFromSlider(sliderR);
        int blue = getIntFromSlider(sliderB);
        byte r = Convert.ToByte(red);
        byte b = Convert.ToByte(blue);
        byte c = Convert.ToByte(current);
        image.color = new Color32(r, c, b, 255);
    }

    public void ChangeColorB(float f)
    {
        Image image = selectedFigure.GetComponent<Image>();
        int current = (int)Mathf.RoundToInt(f);
        int green = getIntFromSlider(sliderG);
        int red = getIntFromSlider(sliderR);
        byte r = Convert.ToByte(red);
        byte g = Convert.ToByte(green);
        byte c = Convert.ToByte(current);
        image.color = new Color32(r, g, c, 255);
    }
    */
}
