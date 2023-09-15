using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Player : MonoBehaviour
{
    public PlayerAnimator Animator;

    [SerializeField] private Joystick m_Joystick;
    [SerializeField] private Rigidbody2D m_Physics;
    [SerializeField] private float m_Speed = 2;


    private void Update()
    {
        Vector2 direction = m_Joystick.direction;
        Animator.SetAnimation(direction);
        if (m_Joystick.isActive)
        {
            m_Physics.velocity = direction * m_Speed;
        }
        else
            m_Physics.velocity = Vector2.zero;
    }
}
