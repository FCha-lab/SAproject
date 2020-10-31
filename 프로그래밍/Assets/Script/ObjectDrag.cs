using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    public Object_Position OP;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        OP = FindObjectOfType(typeof(Object_Position)) as Object_Position;
        transform.position = eventData.position;
        Debug.Log("Drag");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop Drag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        OP.set();
        Debug.Log("End Drag");
    }
}
