using System;

using Unity.VisualScripting;

using UnityEngine;

[CreateAssetMenu(fileName = "DemoCharacter", menuName = "Database/DemoCharacter")]
public class CharacterData : Rarity
{
    [SerializeField] private RuntimeAnimatorController m_Animator;
    [SerializeField] private DefaultProperties m_Health;

    public RuntimeAnimatorController getAnimatorController => m_Animator;

    public override Type GetTepe()
    {
        return typeof(CharacterData);
    }
}

[Serializable]
public struct DefaultProperties
{
    public int Start;
    public int Min;
    public int Max;
}
