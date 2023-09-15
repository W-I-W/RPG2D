

using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator m_Animator;
    [SerializeField] private SpriteRenderer m_Sprite;

    private float m_PreviewDirectionX = 0;
    private const float IdleMinDirection = 0.1f;

    public RuntimeAnimatorController animatorController
    {
        set => m_Animator.runtimeAnimatorController = value;
    }

    public void SetAnimation(Vector2 direction)
    {
        float absDirection = Mathf.Abs(direction.x);
        if (absDirection < IdleMinDirection)
        {
            m_Animator.SetFloat("X", m_PreviewDirectionX / Mathf.PI);
        }
        else
        {
            m_PreviewDirectionX = direction.x;
            m_Sprite.flipX = m_PreviewDirectionX < 0;
            m_Animator.SetFloat("X", absDirection);
        }
    }
}
