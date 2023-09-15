using System.Collections;
using System.Collections.Generic;

using UnityEngine;


[CreateAssetMenu(fileName = "Rarity", menuName = "Database/Rarity")]
public class RarityData : ScriptableObject
{

    [SerializeField] private List<RarityBase<Rarity>> m_Base;

    public Range change { get; set; }

    public List<RarityBase<Rarity>> getBase => m_Base;

    public Rarity GetRarity(List<RarityBase<Rarity>> rarity)
    {
        float percent = Random.Range(0f, change.current / 100f);
        int indexRarity = Mathf.RoundToInt(percent * rarity.Count);
        int maxCharacter = rarity[indexRarity].Objects.Count;
        int indexCharacter = Random.Range(0, maxCharacter);
        return rarity[indexRarity].Objects[indexCharacter];
    }
}

[System.Serializable]
public struct RarityBase<T>
{
    public List<T> Objects;
}
