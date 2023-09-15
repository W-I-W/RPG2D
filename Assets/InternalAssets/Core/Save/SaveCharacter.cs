using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCharacter : MonoBehaviour
{
    [SerializeField] private GameDatabase m_Database;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);   
    }

    private void OnDisable()
    {
        //m_Database.Rarity.playersInStock.Clear();
    }

}
