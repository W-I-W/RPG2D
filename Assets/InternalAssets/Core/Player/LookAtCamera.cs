using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField] private Joystick m_Joystick;
    [SerializeField] private Transform m_LookAt;
    [SerializeField] private float m_ShiftDistance = 2;


    private void Update()
    {
        m_LookAt.localPosition = m_Joystick.direction * m_ShiftDistance;
    }
}
