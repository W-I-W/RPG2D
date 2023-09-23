

using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DemoCharacter : MonoBehaviour
{
    [SerializeField] private Animator m_Animator;

    public StockPlayer player { get; private set; }


    public void SetCharacter(StockPlayer player)
    {
        this.player = player;
        SetAnimatorController(player.Character.getAnimatorController);
    }

    private void SetAnimatorController(RuntimeAnimatorController controller)
    {
        m_Animator.runtimeAnimatorController = controller;
    }
}
