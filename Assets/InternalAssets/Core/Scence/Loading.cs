using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Loading : MonoBehaviour
{
    [SerializeField] private List<GameObject> m_Objects;
    private void Start()
    {
        m_Objects.ForEach((obj) => Instantiate(obj));
        
    }
}

