using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    PlayerController controller;

    bool isPointerDown = false;

    void Start() { controller = FindObjectOfType<PlayerController>(); }

    void Update()
    {
        if (isPointerDown) { controller.DoSomething(true); }
        else { controller.DoSomething(false); }
    }

    public void OnPointerDown(PointerEventData eventData) { isPointerDown = true; }

    public void OnPointerUp(PointerEventData eventData) { isPointerDown = false; }
}