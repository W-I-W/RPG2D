using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class LoadingCharacters : Inject
{
    [SerializeField] private GameDatabase m_Database;
    [SerializeField] private DemoCharacter m_Prefab;

    public List<DemoCharacter> characters { get; private set; }

    private int m_CharacterIndex = 0;
    private List<RarityBase<Rarity>> m_Rarity;

    private int loadCharatersCount => PlayerPrefs.GetInt("Player_Count", 0);


    public override void Init()
    {
        characters = new List<DemoCharacter>();
        InitRarity();

        for (int i = 0; i < m_Database.Objects.Count; i++)
        {
            if (m_Database.Objects[i].getBase[0].Objects[0] is CharacterData)
            {
                m_Rarity = m_Database.Objects[i].getBase;
                break;
            }
        }

        m_Database.playersInStock ??= new List<StockPlayer>();

        if (m_Database.playersInStock.Count == 0)
        {
            if (loadCharatersCount > 0)
            {

            }
            else
            {
                StockPlayer stock = new StockPlayer();
                CharacterData rarity = m_Database.Objects[m_CharacterIndex].GetRarity(m_Database.Objects[m_CharacterIndex].getBase) as CharacterData;
                stock.Character = rarity;
                CreateCharater(stock);
                m_Database.playersInStock.Add(stock);
            }
        }
        else
        {
            m_Database.playersInStock.ForEach(p =>
            {
                CreateCharater(p);
            });
        }
    }

    private void InitRarity()
    {
        Range chance = new Range();
        int current = PlayerPrefs.GetInt("Chance_Rarity_Character", 1);
        chance.current = current;
        m_Database.Objects[0].change = chance;
    }

    private void CreateCharater(StockPlayer player)
    {
        DemoCharacter character = Instantiate(m_Prefab, new Vector3(Random.Range(-4, 4), 0), Quaternion.identity, transform);
        character.SetCharacter(player);
        characters.Add(character);
    }

}

