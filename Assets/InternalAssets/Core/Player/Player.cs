using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private Joystick m_Joystick;
    [SerializeField] private Rigidbody2D m_Physics;
    [SerializeField] private float m_Speed = 2;

    private void Update()
    {
        if (m_Joystick.isActive)
        {
            m_Physics.velocity = m_Joystick.direction *  m_Speed;
        }
        else
            m_Physics.velocity = Vector2.zero;
    }
}
