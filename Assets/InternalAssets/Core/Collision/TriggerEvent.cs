using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent m_OnTriggerEnter;
    [SerializeField] private UnityEvent m_OnTriggerExit;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isPlayer = collision.TryGetComponent(out Player player);
        if (isPlayer)
            m_OnTriggerEnter.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.activeInHierarchy)
        {
            bool isPlayer = collision.TryGetComponent(out Player player);
            if (isPlayer)
                m_OnTriggerExit.Invoke();
        }
    }
}
