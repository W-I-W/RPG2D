using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class LoadingPlayer : MonoBehaviour
{
    [SerializeField] private GameDatabase m_Database;
    [SerializeField] private Player m_Player;

    private void Start()
    {
        m_Player.Animator.animatorController = m_Database.selectedPlayer.Character.getAnimatorController;
    }
}
