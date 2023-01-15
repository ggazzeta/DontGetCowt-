using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FloatingJoystick : Joystick
{

    public static bool wasTouched = false;

    protected override void Start()
    {
        base.Start();
        background.gameObject.SetActive(false);
        GameObject.FindWithTag("Light").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindWithTag("Light").GetComponent<CapsuleCollider2D>().enabled = false;
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
        wasTouched = true;
        background.gameObject.SetActive(true);
        base.OnPointerDown(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        background.gameObject.SetActive(false);
        base.OnPointerUp(eventData);
    }
}