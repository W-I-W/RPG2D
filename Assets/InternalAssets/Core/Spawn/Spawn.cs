using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

using ETouch = UnityEngine.InputSystem.EnhancedTouch;

public class Spawn : MonoBehaviour
{
    [SerializeField] private SpriteRenderer m_SpriteSelect;

    private Camera m_Camera;
    private void Start()
    {
        m_Camera = Camera.main;
        EnhancedTouchSupport.Enable();
        ETouch.Touch.onFingerDown += FingerDown;
    }

    private void FingerDown(Finger finger)
    {

        Vector2 point = m_Camera.ScreenToWorldPoint(finger.screenPosition);
        RaycastHit2D hit = Physics2D.Raycast(point, Vector2.one, 1f);
        if (hit)
        {
            m_SpriteSelect.transform.position = hit.transform.position;
        }
    }
}
