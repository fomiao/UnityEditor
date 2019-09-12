using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//定义中文attribute
public class LabelAttribute : PropertyAttribute
{
    public string label;
    public LabelAttribute(string label)
    {
        this.label = label;
    }
}





