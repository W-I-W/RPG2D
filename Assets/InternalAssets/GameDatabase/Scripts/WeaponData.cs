using System;

using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Database/Weapon")]
public class WeaponData : Rarity
{
    [SerializeField] private Sprite m_Sprite;

    public Sprite sprite => m_Sprite;

    public override Type GetTepe()
    {
        return typeof(WeaponData);
    }
}
