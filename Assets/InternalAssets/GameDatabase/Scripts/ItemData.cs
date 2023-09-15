using System;

using UnityEngine;


[CreateAssetMenu(fileName = "Item", menuName = "Database/Item")]
public class ItemData : Rarity
{
    [SerializeField] private Sprite m_Sprite;

    public Sprite sprite => m_Sprite;

    public override Type GetTepe()
    {
        return typeof(ItemData);
    }
}

