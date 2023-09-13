using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Execute : MonoBehaviour
{
    [SerializeField] private Button m_Button;
    private UnityEvent m_OnPlay;

    private void Start()
    {
        m_Button.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        m_Button.onClick.AddListener(() => m_OnPlay?.Invoke());
    }

    private void OnDisable()
    {
        m_Button.onClick.RemoveAllListeners();
    }

    public void Play(UnityEvent action)
    {
        m_Button.gameObject.SetActive(true);
        m_OnPlay = action;
    }

    public void Clear()
    {
        if (m_Button != null)
            m_Button.gameObject.SetActive(false);
        m_OnPlay = null;
    }
}
