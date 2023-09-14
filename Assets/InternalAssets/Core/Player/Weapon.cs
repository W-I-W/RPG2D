using DG.Tweening;

using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Joystick m_Joystick;
    [SerializeField] private Rigidbody2D m_Weapon;
    [SerializeField] private Rigidbody2D m_Player;
    [SerializeField] private float m_SpeedRotation = 2f;
    [SerializeField] private float m_SpeedMove = 2f;
    [SerializeField] private float m_DistanceMove = 1f;


    private void FixedUpdate()
    {
        if (m_Joystick.isActive)
        {

            float rotation = Mathf.Atan2(m_Joystick.direction.y, m_Joystick.direction.x) * Mathf.Rad2Deg;
            m_Weapon.rotation = Mathf.LerpAngle(m_Weapon.rotation, rotation, m_SpeedRotation);
        }
        Vector2 pointB = m_Player.position + m_Joystick.direction * m_DistanceMove;
        m_Weapon.position = Vector2.Lerp(m_Weapon.position, pointB, m_SpeedMove);
    }
}
