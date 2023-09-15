using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public sealed class Zenject : MonoBehaviour
{
    [SerializeField] private List<Inject> m_Injects;

    private void Start()
    {
        m_Injects.ForEach((i) => i.Init());
    }
}
