using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverLogic : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData data)
    {
        Console.WriteLine("entering" + data.button);
    }

    public void OnPointerExit(PointerEventData data) {
        Console.WriteLine("entering" + data.button);
    }
}
