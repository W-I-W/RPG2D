using System.Collections.Generic;

using UnityEngine;


[CreateAssetMenu(fileName = "Database", menuName = "Database/Data")]
public sealed class GameDatabase : ScriptableObject
{
    public List<RarityData> Objects;

    public StockPlayer selectedPlayer { get; set; }

    public List<StockPlayer> playersInStock { get; set; }


}
