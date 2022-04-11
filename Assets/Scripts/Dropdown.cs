using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown : MonoBehaviour
{
    public GameObject[] objects;
    public int selectedFigure;
    private GameObject inst_obj;
    public GameObject dropdown;

    public Configure configurationPannel;
    // Start is called before the first frame update


    

    public void onClick()
    {
        float spawnX = Random.Range(1050f, 1865f);//1050 - 1865x 50-1000y
        float spawnY = Random.Range(50f, 1000f);
        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        inst_obj = Instantiate(objects[selectedFigure], spawnPos, Quaternion.identity, dropdown.transform.parent.transform.parent.transform.parent.transform.parent.transform) as GameObject;
    }

}
