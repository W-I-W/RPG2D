using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Physics", menuName = "Database/Physics")]
public class PhysicsDamage : TypeDamage
{
    public override void Damage()
    {
        Debug.Log("Physics");
    }
}
