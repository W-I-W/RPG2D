using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExecuteEvent : MonoBehaviour
{
    [SerializeField] private Execute m_Execute;
    [SerializeField] private UnityEvent m_OnPlay;
    
    public void Play()
    {
        m_Execute.Play( m_OnPlay);
    }

    public void Clear()
    {
        m_Execute.Clear();
    }
}
