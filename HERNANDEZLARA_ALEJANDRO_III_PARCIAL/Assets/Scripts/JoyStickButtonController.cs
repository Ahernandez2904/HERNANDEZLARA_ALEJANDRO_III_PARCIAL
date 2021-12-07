using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStickButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    PlayerController avatar;
    bool isPointerDown;

    void Awake() { avatar = FindObjectOfType<PlayerController>(); }

    void Update() { if (isPointerDown) { avatar.Attack(true); } else { avatar.Attack(false); } }

    public void OnPointerDown(PointerEventData eventData) { isPointerDown = true; }
    
    public void OnPointerUp(PointerEventData eventData) { isPointerDown = false; }
}