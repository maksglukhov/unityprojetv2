using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Configure : MonoBehaviour
{
    public static Configure inst;
    public GameObject selectedFigure;
    public Slider slider;
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
        slider.value = localScale.x;
        Debug.Log("Figure selected");
    }

    public void ChangeSize(float f)
    {

        selectedFigure.transform.localScale = new Vector3(f, f, f);

    }

    public void ChangeColor()
    {
        Image image = selectedFigure.GetComponent<Image>();
        image.color = red;
    }
}
