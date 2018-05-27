using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropCards : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool onPointer = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        onPointer = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        onPointer = false;
    }
}
