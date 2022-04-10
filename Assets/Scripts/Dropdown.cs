using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown : MonoBehaviour
{
    public GameObject[] objects;
    public int selectedFigure;
    private GameObject inst_obj;
    public GameObject canvas;

    public Configure configurationPannel;
    // Start is called before the first frame update
    void Start()
    {
        /*var dropdown = transfrom.GetComponent<Dropdown>();
        dropdown.options.Clear();
        List<strinf> items = new List<string>();
        items.Add("Circle");
        items.Add("Square");
        items.Add("Isometric Diamond");
        items.Add("Hexagon Flat-Top");
        items.Add("Hexagon Pointed-Top");
        items.Add("9-Sliced");

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }*/



    }
    //playerCamera = GameObject.Find("MainCamera").GetComponent<Camera>();

    public void createFigure(int val)
    {
        /*var wParent = transform.parent.transform.parent.GetComponent<RectTransform>().rect.width;
        float spawnY = Random.Range
                    (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        float spawnX = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width + wParent, 0)).x);
        Vector2 spawnPos = new Vector2(spawnX, spawnY);*/
        //Instantiate(objects[val], objects[val].transform.position, Quaternion.identity);
        selectedFigure = val;
    }

    public void onClick()
    {
        float spawnX = Random.Range(1050f, 1865f);//1050 - 1865x 50-1000y
        float spawnY = Random.Range(50f, 1000f);
        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        //inst_obj = Instantiate(objects[selectedFigure], objects[selectedFigure].transform.position, Quaternion.identity, canvas.transform) as GameObject;
        inst_obj = Instantiate(objects[selectedFigure], spawnPos, Quaternion.identity, canvas.transform) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
