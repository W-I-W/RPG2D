using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Magic", menuName = "Database/Magic")]
public class MagicDamage : TypeDamage
{
    public override void Damage()
    {
        Debug.Log("Magic");
    }
}
