using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData) 
    {
        // Get the position delta from the user's dragging action
        Vector2 delta = eventData.delta;

        // Get the current position of the panel
        RectTransform panelRectTransform = transform as RectTransform;
        Vector2 currentPosition = panelRectTransform.anchoredPosition;

        // Update the position of the panel based on the user's dragging action
        panelRectTransform.anchoredPosition = currentPosition + delta;
    }
}
