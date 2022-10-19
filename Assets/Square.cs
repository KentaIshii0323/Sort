using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public enum COLOR
    {
        RED,
        PURPLE,
        BULUE,
        GREEN,
        YELLOW,
    };

    public COLOR color;

    public void onClickThis()
    {
        SwitchObj.instance.OnClickSquare(color, gameObject.transform);
    }
}
