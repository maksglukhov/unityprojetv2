using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose : MonoBehaviour
{
    public void setChoice()
    {
        Debug.Log("test");
        Configure.inst.setFigure(this.gameObject);
    }
}
