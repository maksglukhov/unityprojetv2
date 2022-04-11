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
    public Slider sliderX;
    public Slider sliderY;
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

        Vector2 currentPos = selectedFigure.transform.localPosition;
        Debug.Log(currentPos.x);
        Debug.Log(currentPos.y);

        sliderX.value = currentPos.x + 960f;
        sliderY.value = currentPos.y + 540f; 
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
        byte green = Convert.ToByte(sliderG.value);
        byte blue = Convert.ToByte(sliderB.value);
        image.color = new Color32(current, green, blue, 255);
    }



    public void ChangeColorG(float f)
    {
        Image image = selectedFigure.GetComponent<Image>();
        byte current = Convert.ToByte(f);
        byte red = Convert.ToByte(sliderR.value);
        byte blue = Convert.ToByte(sliderB.value);
        image.color = new Color32(red, current, blue, 255);
    }

    public void ChangeColorB(float f)
    {
        Image image = selectedFigure.GetComponent<Image>();
        byte current = Convert.ToByte(f);
        byte green = Convert.ToByte(sliderG.value);
        byte red = Convert.ToByte(sliderR.value);
        image.color = new Color32(red, green, current, 255);
    }

    public void ChangeColor()
    {
        Destroy(selectedFigure);
    }

    public byte getIntFromSlider(Slider s)
    {
        byte b = Convert.ToByte(s.value);
        return b;
    }

    public void ChangePosX(float f)
    {
        float y = sliderY.value;
        selectedFigure.transform.position = new Vector2(f, y);
    }

    public void ChangePosY(float f)
    {
        float x = sliderX.value;
        selectedFigure.transform.position = new Vector2(x, f);
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
